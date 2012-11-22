using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;

namespace S2MP.Query
{
    public interface IQueryResult
    {
        /// <summary>
        /// Template used for generate result.
        /// </summary>
        Template TemplateUsed { get; set; }

        /// <summary>
        /// Query result.
        /// </summary>
        string Result { get; set; }
    }
}
