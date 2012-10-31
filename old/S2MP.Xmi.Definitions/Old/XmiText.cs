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
    [XmlType(TypeName = Constants.TypeNameText)]
    public class XmiText : IXmiObject
    {
        //[XmlAttribute(Constants.AttributeNameId, Namespace = Constants.XmiNamespace)]
        [XmlAttribute(Constants.AttributeNameId)]
        public String Id { get; set; }

        [XmlAttribute(Constants.AttributeNameValue)]
        public String Value { get; set; }
    }
}