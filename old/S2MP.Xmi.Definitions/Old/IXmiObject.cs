using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace S2MP.RuleXpressToXMI.Definitions.Custom.Old
{
    [Serializable]
    [XmlInclude(typeof(Xmi))]
    [XmlInclude(typeof(XmiDesignation))]
    [XmlInclude(typeof(XmiObjectType))]
    [XmlInclude(typeof(XmiText))]
    [XmlRoot(Namespace = "inh")]
    public abstract class IXmiObject
    {
    }
}