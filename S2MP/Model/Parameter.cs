using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace S2MP.Model
{
    [XmlRoot("parameter")]
    public class Parameter
    {

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "isInput")]
        public bool IsInput { get; set; }
    }
}
