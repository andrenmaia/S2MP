using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using S2MP.Management;

namespace S2MP.Query
{
    /// <summary>
    /// Query abstract.
    /// </summary>
    public abstract class Query: IQuery
    {
        #region Attribute

        /// <summary>
        /// Selected template to result.
        /// </summary>
        internal Template SelectedTemplateToResult { get; set; }

        #endregion

        #region Methods
        
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

        #endregion
    }
}
