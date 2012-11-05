using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;

namespace S2MP.Query
{
    /// <summary>
    /// Query result over sbvr rules.
    /// </summary>
    public class QueryResult
    {
        #region Properties

        /// <summary>
        /// Template used for generate result.
        /// </summary>
        internal Template TemplateUsed { get; set; }

        /// <summary>
        /// Query result.
        /// </summary>
        public string Result { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new QueryResult and fill Result property.
        /// </summary>
        /// <param name="templateToWrite">
        /// Template to write query result.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If parameters are null or empty.
        /// </exception>
        internal QueryResult(Template templateToWrite, string result)
        {
            //
            // Check if parameters are null and set values to attributes.
            //

            if (templateToWrite == null)
                throw new ArgumentNullException("templateToWrite");

            if (string.IsNullOrEmpty(result))
                throw new ArgumentNullException("templateToWrite");

            TemplateUsed = templateToWrite;
            Result = result;
        }

        #endregion
    }
}
