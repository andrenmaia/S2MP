using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using System.IO;
using System.Xml.Serialization;

namespace S2MP.Management
{

    // UNDONE: dividir em 2 classes.
    /// <summary>
    /// A manager to S2MP. 
    /// Resposible to maintain global informations de selected information by user.
    /// </summary>
    public class Manager
    {
        #region Attributes

        /// <summary>
        /// Maintains only one instance in memory (singleton).
        /// </summary>
        private static Manager _instance;

        /// <summary>
        /// True if set up was executed, otherwise false.
        /// </summary>
        private static bool _wasSetUp;

        #endregion

        #region Properties

        /// <summary>
        /// Get a instance of Manager (Singleton).
        /// </summary>
        public static Manager GetInstance
        {
            get
            {
                // Check setup.
                if (!_wasSetUp) throw new InvalidOperationException("S2MP was not set up.");

                //// Ensures exclusive access and instanciate the Manager.
                //lock (_instance)
                //{
                if (_instance == null)
                    _instance = new Manager();
                //}

                return _instance;
            }

        }

        /// <summary>
        /// Get current set up of S2MP.
        /// </summary>
        internal static Setup CurrentSetUp { get; private set; }

        /// <summary>
        /// A hash of templates loaded.
        /// </summary>
        private static Dictionary<string, Template> _templatesLoaded;

        #endregion

        #region Contructors
        static Manager()
        {
            // Initialize.
            _templatesLoaded = new Dictionary<string, Template>();
        }

        private Manager() { }

        #endregion

        #region Methods

        // UNDONE: Implementar um pattern criacional aqui.
        /// <summary>
        /// Set up manager.
        /// </summary>
        /// <param name="setup">
        /// 
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// When set up have alread been executed.
        /// </exception>
        public static void SetupManager(Setup setup)
        {
            if (_wasSetUp)
                throw new InvalidOperationException("Set up S2MP have already been executed.");

            CurrentSetUp = setup;


            loadTemplates();

            _wasSetUp = true;
        }

        private static void loadTemplates()
        {
            foreach (var file in Directory.GetFiles(CurrentSetUp.TemplatesPath, "*.txml", SearchOption.AllDirectories))
            {
                XmlSerializer x = new XmlSerializer(typeof(Template));
                Template tmp = x.Deserialize(File.Open(file, FileMode.Open)) as Template;
                if (tmp == null)
                    throw new NullReferenceException(string.Concat("It was not possible deserialize file \"", file, "\" in Template."));

                _templatesLoaded.Add(Tuple.Create(tmp.Name, tmp.Language).ToString(), tmp);
            }
        }

        internal Template FindTemplate(string name, Languages language = Languages.None)
        {
            return _templatesLoaded[Tuple.Create(name, (language == Languages.None) ? Manager.CurrentSetUp.DefaultLanguageOfQueryResult : language).ToString()];

            //// TODO: Ler o template real de acordo com a parametrização.
            //// TODO: Obter template da pasta de templates padrão.
            //return new Template()
            //{
            //    Language = LanguageEnum.Csharp,
            //    Name = "AtLeastN",
            //    Path = Manager.GetInstance.CurrentSetUp.TemplatesPath,
            //    Version = "1.0"
            //};
        }

        #endregion

    }
}
