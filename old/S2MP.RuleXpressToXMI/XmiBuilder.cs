
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S2MP.RuleXpressToXMI.Custom;
using S2MP.RuleXpressToXMI.Definition;
using S2MP.RuleXpressToXMI.Definition.Old;

namespace S2MP.RuleXpressToXMI.Custom.Old
{
    /// <summary>
    /// Builder
    /// </summary>
    public abstract class XmiBuilder
    {
        public abstract void BuildPart(RuleXpressPublication file);
        public abstract S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi GetResult();
    }
}
