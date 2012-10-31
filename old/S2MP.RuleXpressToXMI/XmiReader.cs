using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using S2MP.Common;
using S2MP.RuleXpressToXMI.Custom;
using S2MP.RuleXpressToXMI.Definition;
using S2MP.RuleXpressToXMI.Definition.Old;

namespace S2MP.RuleXpressToXMI.Custom.Old
{
    /// <summary>
    /// Director
    /// </summary>
    public class XmiReader
    {
        internal XmiBuilder _builder;

        public String XmlFile { get; private set; }
        public String XmiFile { get; private set; }
        public RuleXpressPublication RuleXpressFile { get; private set; }

        public XmiReader(String pXmlFile, String pXmiFile)
        {
            if (!File.Exists(pXmlFile))
            {
                throw new FileNotFoundException();
            }

            this.XmlFile = pXmlFile;
            this.XmiFile = pXmiFile;

            _builder = new Xmi21();
        }


        private void saveXmiFile()
        {
            try
            {
                if (this.RuleXpressFile == null)
                {
                    throw new XmlException(RX2XConstants.cMsgRXXmlFileNotRead);
                }

                XmlWriter writer = XmlWriter.Create(File.CreateText(this.XmiFile));
                XmlSerializerNamespaces serializerNS = new XmlSerializerNamespaces();
                serializerNS.Add(Constants.SbvrPrefix, Constants.SbvrNamespace);
                serializerNS.Add(Constants.XmiPrefix, Constants.XmiNamespace);
                serializerNS.Add("inh", "http://www.w3.org/2001/XMLSchema-instance");





                _builder.BuildPart(this.RuleXpressFile);
                S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi xmi = _builder.GetResult();

                XmlSerializer serializer = new XmlSerializer(typeof(S2MP.RuleXpressToXMI.Definitions.Custom.Old.Xmi));
                serializer.Serialize(writer, xmi, serializerNS);

                Console.Write("fim");
            }
            catch (Exception exc)
            {
                Exception excAux = exc;
                String strExc = String.Empty;
                Console.WriteLine("DEU ERRO!");
                do
                {
                    strExc += String.Concat("Mensagem: ", excAux.Message, "\r\n");
                    excAux = excAux.InnerException;
                } while (excAux != null);
                Console.Write(strExc);
            }
        }

        private void readXmlFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RuleXpressPublication));
            this.RuleXpressFile = serializer.Deserialize(File.OpenRead(this.XmlFile)) as RuleXpressPublication;
        }

        public void ProcessFile()
        {
            this.readXmlFile();
            this.saveXmiFile();
        }
    }
}
