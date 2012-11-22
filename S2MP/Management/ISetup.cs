using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;

namespace S2MP.Management
{
    public interface ISetup
    {

        /// <summary>
        /// Path to file xmi from sbvr.
        /// </summary>
        string XmiPath { get; set; }

        /// <summary>
        /// Directory path of templates.
        /// </summary>
        string TemplatesPath { get; set; }

        /// <summary>
        /// Selected language of query result.
        /// </summary>
        Languages DefaultLanguageOfQueryResult { get; set; }

    }
}
