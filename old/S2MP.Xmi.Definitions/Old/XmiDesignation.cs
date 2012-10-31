using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using S2MP.Common;

namespace S2MP.RuleXpressToXMI.Definitions.Custom.Old
{
    [Serializable]
    [XmlType(TypeName = Constants.TypeNameDesignation)]
    [XmlRoot(ElementName = Constants.TypeNameDesignation, Namespace = Constants.SbvrNamespace)]
    public class XmiDesignation : IXmiObject
    {
        [XmlAttribute(Constants.AttributeNameId, Namespace = Constants.XmiNamespace)]
        public String Id { get; set; }

        [XmlAttribute(Constants.AttributeNameSignifier)]
        public String Signifier { get; set; }

        [XmlAttribute(Constants.AttributeNameMeaning)]
        public String Meaning { get; set; }
    }
}