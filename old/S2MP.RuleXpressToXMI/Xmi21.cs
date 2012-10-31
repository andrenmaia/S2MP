using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S2MP.RuleXpressToXMI.Custom;
using S2MP.RuleXpressToXMI.Definition;
using S2MP.RuleXpressToXMI.Definition.Old;
using S2MP.RuleXpressToXMI.Definitions.Custom.Old;

namespace S2MP.RuleXpressToXMI.Custom.Old
{
    public class Xmi21 : XmiBuilder
    {
        public const String Version = "2.1";

        S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi result;
        Term21Factory _term;

        public override void BuildPart(RuleXpressPublication file)
        {
            result = new S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi();
            result.Version = Version;

            _term = new Term21Factory(file);

            buildTerm();
        }

        private void buildTerm()
        {
            result.Term = _term.GetResult();
        }

        public override S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi GetResult()
        {
            return result;
        }
    }
}