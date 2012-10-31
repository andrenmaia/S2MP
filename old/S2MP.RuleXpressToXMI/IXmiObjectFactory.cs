using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using S2MP.RuleXpressToXMI.Custom;
using S2MP.RuleXpressToXMI.Custom.Old;

namespace S2MP.RuleXpressToXMI.Definitions.Custom.Old
{
    public interface IXmiObjectFactory
    {
        List<IXmiObject> GetResult();
    }
}