using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Management;

namespace S2MP.Query
{
    internal class QueryContext
    {
        Dictionary<string, IQueryStrategy> _strategies;

        public QueryContext()
        {
            _strategies = new Dictionary<string, IQueryStrategy>();
        }

        public List<IQueryResult> Search(string context, Dictionary<string, string> param)
        {
            if (_strategies.Count <= 0 || !_strategies.ContainsKey(context))
            {

                if (context == typeof(LogicalFormulationQuery).Name)
                    _strategies.Add(typeof(LogicalFormulationQuery).Name, new LogicalFormulationQuery(param));

                else if (context == typeof(SemanticFormulationQuery).Name)
                    _strategies.Add(typeof(SemanticFormulationQuery).Name, new SemanticFormulationQuery(param));

                else if (context == typeof(ProjectionQuery).Name)
                    _strategies.Add(typeof(ProjectionQuery).Name, new ProjectionQuery(param));

                else
                    throw new KeyNotFoundException("O context não foi encontrado.");

            }

            return _strategies[context].Parse();
        }
    }
}
