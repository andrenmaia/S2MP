using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace S2MP.Model
{
    /// <summary>
    /// Template representation.
    /// </summary>
    public class Template
    {
        #region Properties

        /// <summary>
        /// Template name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Template version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Template path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Template text to parse.
        /// </summary>
        public string TextTemplateToParse { get; set; }

        /// <summary>
        /// Template language.
        /// </summary>
        public LanguageEnum Language { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Get a text template parsed.
        /// </summary>
        /// <param name="parameters">
        /// Dictionary of parameters for template.
        /// </param>
        /// <returns>
        /// String parse result.
        /// </returns>
        internal string GetTextTemplateParsed(Dictionary<string, string> parameters)
        {
            //
            // Get parameters and replace it in textTemplateToParse.
            //

            //
            // UNDONE: deve ser lido do aquivo xml do template.
            //
            TextTemplateToParse = "if (@@entityA@@.Count < @@N@@) " + Environment.NewLine + "{ throw new BusinessException(\"A quantidade de @@entityA@@ deve ser maior que @@N@@\"; }";
            //

            string textCopy = TextTemplateToParse; // make a copy.

            foreach (var key in parameters.Keys)
            {
                // If key doesn't match textTemplateToParse, throw exception.
                if (new Regex("/" + key + "/", RegexOptions.Multiline).IsMatch(textCopy, 0))
                    throw new TemplateParseException(key, textCopy);


                textCopy = textCopy.Replace(key, parameters[key]);
            }



            // System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Template));
            // x.Serialize(System.IO.File.CreateText(@"C:\Users\Maia\Downloads\S2MP\S2MP\S2MP\Templates\xml.xml"), this);

            return textCopy;
        }

        #endregion

    }
}
