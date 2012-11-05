using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Query;

namespace S2MP.Model
{
    public interface IS2MPCommand
    {
        List<QueryResult> ExecuteQuery(Query.Query query);
    }
}
