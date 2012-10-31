using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.RuleXpressToXMI.Custom;
using S2MP.RuleXpressToXMI.Definition;
using S2MP.RuleXpressToXMI.Definition.Old;

namespace S2MP.RuleXpressToXMI.Definitions.Custom.Old
{
    public class Term21Factory : IXmiObjectFactory
    {
        RuleXpressPublication _file;

        public Term21Factory(RuleXpressPublication file)
        {
            this._file = file;
        }

        public List<IXmiObject> GetResult()
        {
            List<IXmiObject> result = new List<IXmiObject>();

            foreach (Term term in _file.Content[0].Term)
            {
                XmiDesignation designation = new XmiDesignation() { Id = term.signifier };

                result.Add(designation);
                result.Add(ReadObjectType(term, designation));
                result.Add(ReadText(term, designation));
            }

            return result;
        }

        private IXmiObject ReadObjectType(Term pTerm, XmiDesignation designation)
        {
            string id = designation.Id + "-c";
            designation.Meaning = id;
            return new XmiObjectType() { Id = id };
        }

        /// <summary>
        /// Obtém o StrVal da representação.
        /// </summary>
        /// <param name="pTerm">Termo de onde será obtido.</param>
        /// <returns></returns>
        /// <remarks>
        ///       <ItemProperties>
        ///        <GroupName>A. Representation</GroupName>
        ///        <ItemProperty ConceptID="2">
        ///          <Name>Synonym</Name>
        ///          <Value StrVal="company" PropertyValueID="2329">
        ///            <Text>company</Text>
        ///          </Value>
        ///          <SubProperty ConceptID="95">
        ///            <Name>WPAR</Name>
        ///            <Value />
        ///          </SubProperty>
        ///        </ItemProperty>
        ///      </ItemProperties>
        /// </remarks>
        private IXmiObject ReadText(Term pTerm, XmiDesignation designation)
        {
            foreach (ItemProperties itemProperty in pTerm.ItemProperties)
            {
                foreach (ItemPropertiesItemProperty itemPropertiesItemProperty in itemProperty.ItemProperty)
                {
                    if (itemPropertiesItemProperty.ConceptID.Equals("2")) // GroupName = 'A. Representation'
                    {
                        foreach (ItemPropertiesItemPropertyValue itemPropertiesItemPropertyValue in itemPropertiesItemProperty.Value)
                        {
                            string id = designation.Id + "-t";
                            designation.Signifier = id;
                            return new XmiText() { Id = id, Value = itemPropertiesItemPropertyValue.StrVal };
                        }
                    }
                }
            }

            return null;
        }
    }
}