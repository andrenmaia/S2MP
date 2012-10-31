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
    [XmlType(TypeName = Constants.TypeNameObjectType)]
    [XmlRoot(ElementName = Constants.TypeNameObjectType, Namespace = Constants.SbvrNamespace)]
    public class XmiObjectType : IXmiObject
    {
        [XmlAttribute(Constants.AttributeNameId, Namespace = Constants.XmiNamespace)]
        public String Id { get; set; }
    }
}