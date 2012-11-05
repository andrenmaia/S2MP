﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Query
{
    /// <summary>
    /// Query interface.
    /// </summary>
    public interface IQuery
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
        List<QueryResult> Parse();
    }
}
