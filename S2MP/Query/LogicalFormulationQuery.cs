using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using S2MP.Management;

namespace S2MP.Query
{
    public class LogicalFormulationQuery : Query
    {

        #region IQuery Members

        public sealed override List<IQueryResult> Parse()
        {
            string result = base.SelectedTemplateToResult.GetTextTemplateParsed(new Dictionary<string, string>() 
                                                        {
                                                            { "@@entityA@@", _entityA},
                                                            { "@@entityB@@", _entityB},
                                                            { "@@n@@", _n.ToString()}
                                                        }
                                                    );

            return new List<IQueryResult>() { new QueryResult(base.SelectedTemplateToResult, result) };
        }

        #endregion

        #region Attributes

        private string _entityA;
        private string _entityB;
        private int _n;

        #endregion

        #region Constructor


        public LogicalFormulationQuery()
        {
        }

        public LogicalFormulationQuery(Dictionary<string, string> param)
        {
            this._entityA = param["entityA"];
            this._entityB = param["entityB"];
            // this._n = int.Parse(param["n"]);

            this._n = 3;

            SelectedTemplateToResult = Manager.GetInstance.FindTemplate("Logical Formulation - At-Least-N Quantification");
        }


        #endregion

    }
}
