using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Query;

namespace S2MP.Model
{
    /// <summary>
    /// It is a template writer.
    /// </summary>
    public class S2MPCommand
    {
        #region Methods

        /// <summary>
        /// Write a template.
        /// </summary>
        /// <param name="query">
        /// Query to get results.
        /// </param>
        /// <param name="templateToWrite">
        /// Template to write.
        /// </param>
        /// <returns>
        /// Code written based on template.
        /// </returns>
        public List<QueryResult> ExecuteQuery(Query.Query query)
        {
            return query.Parse();
        }

        #endregion

    }
}
