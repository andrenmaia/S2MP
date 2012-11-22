using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Query
{
    internal class ProjectionQuery: Query
    {
        public ProjectionQuery(Dictionary<string,string> param)
        {

        }
        public override List<IQueryResult> Parse()
        {
            throw new NotImplementedException();
        }
    }
}
