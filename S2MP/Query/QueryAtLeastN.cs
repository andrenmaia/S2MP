using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Model;
using S2MP.Management;

namespace S2MP.Query
{
    public class QueryAtLeastN : Query
    {

        #region IQuery Members

        public sealed override List<QueryResult> Parse()
        {
            string result = base.TemplateToResult.GetTextTemplateParsed(new Dictionary<string, string>() 
                                                        {
                                                            { "@@entityA@@", _entity},
                                                            { "@@N@@", _n.ToString()}
                                                        }
                                                    );

            return new List<QueryResult>() { new QueryResult(base.TemplateToResult, result) };
        }

        #endregion

        #region Attributes

        private string _entity;
        private int _n;

        #endregion


        #region Constructor

        public QueryAtLeastN(string entity, int n)
        {
            this._entity = entity;
            this._n = n;

            // TODO: Implementar um pattern criacional aqui.
            TemplateToResult = Manager.GetInstance.FindTemplate("AtLeastN");
        }


        #endregion

    }
}
