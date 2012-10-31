using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using S2MP.Management;

namespace S2MP.Query
{
    /// <summary>
    /// Query interface.
    /// </summary>
    public abstract class Query
    {

        #region Attribute

        protected Template TemplateToResult { get; set; }

        #endregion


        /// <summary>
        /// Parse a query.
        /// </summary>
        /// <param name="templateToResult">
        /// Template to query results.
        /// </param>
        /// <returns>
        /// Collection of QueryResult match between IQuery and SBVR objects.
        /// </returns>
        public abstract List<QueryResult> Parse();
        
    }
}
