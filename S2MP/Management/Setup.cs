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
        /// Path to file xmi from sbvr.
        /// </summary>
        public string XmiPath  { get; set; }

        /// <summary>
        /// Directory path of templates.
        /// </summary>
        public string TemplatesPath { get; private set; }

        /// <summary>
        /// Selected language of query result.
        /// </summary>
        public Languages DefaultLanguageOfQueryResult { get; private set; }


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
        public Setup(string xmiPath, string templatePath, Languages defaultLanguageOfQueryResult)
        {
            if (string.IsNullOrEmpty(xmiPath) || !File.Exists(xmiPath))
                throw new FileNotFoundException(string.Concat("The path \"", xmiPath, "\" is invalid."));

            if (string.IsNullOrEmpty(templatePath) || !Directory.Exists(templatePath))
                throw new DirectoryNotFoundException(string.Concat("The path \"", templatePath, "\" is invalid."));

            this.XmiPath = xmiPath;
            this.TemplatesPath = templatePath;
            this.DefaultLanguageOfQueryResult = defaultLanguageOfQueryResult;

        }

        #endregion
    }
}
