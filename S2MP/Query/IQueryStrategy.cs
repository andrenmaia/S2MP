using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Query
{
    internal interface IQueryStrategy
    {
        /// <summary>
        /// Parse a query.
        /// </summary>
        /// <param name="templateToResult">
        /// Template to query results.
        /// </param>
        /// <returns>
        /// Collection of QueryResult match between IQuery and SBVR objects.
        /// </returns>
        List<IQueryResult> Parse();
    }
}
