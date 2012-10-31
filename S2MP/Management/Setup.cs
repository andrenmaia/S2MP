using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using System.IO;

namespace S2MP.Management
{
    public class Setup
    {
        /// <summary>
        /// Directory path of templates.
        /// </summary>
        public string TemplatesPath { get; private set; }

        /// <summary>
        /// Selected language of query result.
        /// </summary>
        public LanguageEnum DefaultLanguageOfQueryResult { get; private set; }


        #region Constructors

        /// <summary>
        /// Create a set up for Manager.
        /// </summary>
        /// <param name="templatePath">
        /// Directory path of templates.
        /// </param>
        /// <param name="defaultLanguageOfQueryResult">
        /// Selected language of query result.
        /// </param>
        public Setup(string templatePath, LanguageEnum defaultLanguageOfQueryResult)
        {
            if (string.IsNullOrEmpty(templatePath) && !Directory.Exists(templatePath))
                throw new DirectoryNotFoundException(string.Concat("The path \"", templatePath, "\" is invalid."));


            this.TemplatesPath = templatePath;
            this.DefaultLanguageOfQueryResult = defaultLanguageOfQueryResult;

        }

        #endregion
    }
}
