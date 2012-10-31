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
    [XmlInclude(typeof(Xmi))]
    [XmlInclude(typeof(XmiDesignation))]
    [XmlInclude(typeof(XmiObjectType))]
    [XmlInclude(typeof(XmiText))]
    [XmlRoot(ElementName = Constants.ElementNameXmi)]
    // [XmlRoot(Namespace = Constants.XmiNamespace) , ElementName = Constants.cElementNameXmi)]
    public class Xmi
    {

        public Xmi()
        {
            if (Term == null)
                Term = new List<IXmiObject>();
        }

        //[XmlAttribute(Constants.cAttributeNameVersion, Namespace = Constants.XmiNamespace)]
        [XmlAttribute(Constants.AttributeNameVersion)]
        public string Version { get; set; }

        [XmlIgnore]
        public List<IXmiObject> Term { get; set; }

        //[XmlElement(Namespace = Constants.SbvrNamespace)]
        //public XmiDesignation Des
        //{
        //    get
        //    {
        //        return new XmiDesignation() { Id = "130" };
        //    }
        //    set
        //    {
        //    }
        //}

        [XmlElement(Namespace = Constants.SbvrNamespace, ElementName = Constants.TypeNameDesignation)]
        public List<IXmiObject> Designations
        {
            get { return Term.FindAll(x => x is XmiDesignation).ToList(); }
            set
            {
                Term.AddRange(value);
            }
        }
        [XmlElement(Namespace = Constants.SbvrNamespace, ElementName = Constants.TypeNameObjectType)]
        public List<IXmiObject> ObjectTypes
        {
            get { return Term.FindAll(x => x is XmiObjectType).ToList(); }
            set
            {
                Term.AddRange(value);
            }
        }
        [XmlElement(Namespace = Constants.SbvrNamespace, ElementName = Constants.TypeNameText)]
        public List<IXmiObject> Texts
        {
            get { return Term.FindAll(x => x is XmiText).ToList(); }
            set
            {
                Term.AddRange(value);
            }
        }
    }
}