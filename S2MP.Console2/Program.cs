using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using S2MP;
using S2MP.Xmi.Definitions;
using S2MP.Util;
using S2MP.Query;
using S2MP.Model;
using S2MP.Management;

namespace S2MP.Console2
{
    class Program
    {

        public class MyFact
        {
            public String Text { get; set; }
            public List<String> Terms { get; set; }
            public List<String> Verbs { get; set; }
        }

        public enum SerializationOptions
        {
            TermVerbTerm,
        }

        static void Main(string[] args)
        {
            // SerializeDesignation();

            // DeserializeXmi();

            //SerializeInput("company appoints officer|t:company;officer|v:appoints", "cao.xml");
            //SerializeInput("rental has requested car group|t:rental;requested car group|v:has", "rhrcg.xml");


            // S2MP.Xmi.Definitions.actuality

            Manager.SetupManager(new Setup(
                                        @"C:\Users\Maia\Downloads\S2MP\S2MP\S2MP\Templates",
                                        LanguageEnum.Csharp
                                    )
                                );

            S2MPCommand cmd = new S2MPCommand();
            foreach (var item in cmd.ExecuteQuery(new QueryAtLeastN("Client", 10)))
                Console.Write(item.Result);

            Console.Read();
        }

        private static void DeserializeXmi()
        {
            XmlSerializer ser = new XmlSerializer(typeof(XMI));
            XMI x = ser.Deserialize(File.OpenText("exemplo1.xml")) as XMI;
            List<sententialForm> y = SBVRSerialize.Deserializer<sententialForm>(x);
        }

        private static void SerializeDesignation()
        {
            designation d = new designation();
            d.expression = "expression";
            d.implicitlyIsUnderstood = true;
            d.id = Guid.NewGuid().ToString();
            d.meaning = "meaning";
            d.name = new string[] { "name1", "name2" };
            d.signifier = "signifier";
            d.version = "2.1";

            XmlSerializer ser = new XmlSerializer(typeof(designation));
            ser.Serialize(File.CreateText("output.xml"), d);
        }

        private static Dictionary<String, String> dicSerialization;

        /// <summary>
        /// Serializa a entrada.
        /// </summary>
        /// <param name="pInput">Entrada que será serializada. Deve estar no formato: Fato|t:termo1;termo2;termoN|n:nome1;nome2;nomeN|v:verbo|kw:palavraChave1;palavraChave2;palavraChaveN</param>
        /// <param name="pOutputFile">Arquivo onde será gerada a saída serializada.</param>
        /// <remarks>
        /// <para>Nomes ainda não são tradados.</para>
        /// <para>Todas as designações devem estar exatamente iguais estão indicadas no fato.</para>
        /// <para>Verificar se as tags XML já existem com o mesmo ID gerado no arquivo destino.</para>
        /// </remarks>
        private static void SerializeInput(String pInput, String pOutputFile)
        {
            if (File.Exists(pOutputFile))
            {
                File.Delete(pOutputFile);
            }

            dicSerialization = new Dictionary<String, String>();
            String[] secoes = pInput.ToLower().Split('|');

            String xml = String.Empty;

            foreach (String item in secoes)
            {
                if (item.StartsWith("t:"))
                {
                    xml += SerializeTerms(item.Substring(2).Split(';'));
                }
                else if (item.StartsWith("v:"))
                {
                    xml += SerializeVerb(item.Substring(2), secoes[0]);
                }
            }

            //File.AppendAllText(pOutputFile, String.Concat("﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>", xml));
            File.AppendAllText(pOutputFile, xml);
        }
        private static String Serialize<T>(T pObject) where
            T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(ms, Encoding.UTF8);
            XmlSerializerNamespaces serializerNS = new XmlSerializerNamespaces();
            serializerNS.Add("sbvr", "http://www.omg.org/spec/SBVR/20070901/SBVR.xml");
            serializerNS.Add("xmi", "http://schema.omg.org/spec/XMI/2.1");
            xmlTextWriter.Formatting = Formatting.Indented;
            serializer.Serialize(xmlTextWriter, pObject, serializerNS);
            ms = (MemoryStream)xmlTextWriter.BaseStream;
            // Remove o que é "desnecessário"
            return Encoding.UTF8.GetString(ms.ToArray()).
                Replace("﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>", String.Empty).
                Replace("xmlns:xmi=\"http://schema.omg.org/spec/XMI/2.1\" ", String.Empty).
                Replace("xmlns:sbvr=\"http://www.omg.org/spec/SBVR/20070901/SBVR.xml\" ", String.Empty).
                Replace("xmi:version=\"2.1\" ", String.Empty);
        }

        private static String GerarId(String pText)
        {
            String[] partes = pText.Split(' ');

            for (int i = 1; i < partes.Length; i++)
            {
                partes[i] = char.ToUpper(partes[i][0]) + partes[i].Substring(1);
            }

            return String.Join(String.Empty, partes);
        }
        private static String GerarIdReduzida(String pText)
        {
            String[] partes = pText.Split(' ');

            for (int i = 0; i < partes.Length; i++)
            {
                partes[i] = partes[i][0].ToString();
            }

            return String.Join(String.Empty, partes);
        }

        private static String SerializeTerms(String[] pTerms)
        {
            /* GERA XML NO SEGUINTE FORMATO:
                <sbvr:designation xmi:id="term" signifier="term-t" meaning="term-c"/>
                <sbvr:objectType xmi:id="term-c"/>
                <sbvr:text xmi:id="term-t" value="term"/>
             */
            String id = null, xml = String.Empty;
            designation d = null;
            objectType ot = null;
            text t = null;
            foreach (String term in pTerms)
            {
                id = GerarId(term);
                d = new designation() { id = id, signifier = String.Concat(id, "-t"), meaning = String.Concat(id, "-c") };
                ot = new objectType() { id = d.meaning };
                t = new text() { id = d.signifier, value = term };

                xml += Serialize<designation>(d);
                xml += Serialize<objectType>(ot);
                xml += Serialize<text>(t);

                dicSerialization.Add(id, term);
            }

            return xml;
        }

        private static String SerializeVerb(String pVerb, String pFact)
        {
            /* GERA XML NO SEGUINTE FORMATO:
                <sbvr:sententialForm xmi:id="companyAppointsOfficer" expression="cao-t" meaning="cao-c" placeholder="cao-p1 cao-p2"/>
                <sbvr:factType xmi:id="cao-c" role="cao-r1 cao-r2"/>
                <sbvr:factTypeFormDemonstratesDesignation factTypeForm="companyAppointsOfficer" designation="appoints"/>
                <sbvr:designation xmi:id="appoints" signifier="appoints-t" meaning="cao-c"/>
                <sbvr:text xmi:id="cao-t" value="company appoints officer"/>
                <sbvr:text xmi:id="appoints-t" value="appoints"/>
                <sbvr:placeholder xmi:id="cao-p1" expression="company-t" startingCharacterPosition="i1" meaning="cao-r1"/>
                <sbvr:placeholderUsesDesignation placeholder="cao-p1" designation="company"/>
                <sbvr:concept1SpecializesConcept2 concept1="cao-r1" concept2="company-c"/>
                <sbvr:factTypeRole xmi:id="cao-r1"/>
                <sbvr:positiveInteger xmi:id="i1" value="1"/>
                <sbvr:placeholder xmi:id="cao-p2" expression="officer-t" startingCharacterPosition="i18" meaning="cao-r2"/>
                <sbvr:placeholderUsesDesignation placeholder="cao-p2" designation="officer"/>
                <sbvr:concept1SpecializesConcept2 concept1="cao-r2" concept2="officer-c"/>
                <sbvr:factTypeRole xmi:id="cao-r2"/>
                <sbvr:positiveInteger xmi:id="i18" value="18"/>
             */
            String id = GerarId(pFact);
            String idReduzida = GerarIdReduzida(pFact);
            String idVerb = GerarId(pVerb);
            String xml = String.Empty;
            sententialForm sf = new sententialForm() { id = id, expression = String.Concat(idReduzida, "-t"), meaning = String.Concat(idReduzida, "-c"), placeholder = String.Format("{0}-p1 {0}-p2", idReduzida) };
            factType ft = new factType() { id = sf.meaning, role = String.Format("{0}-r1 {0}-r2", idReduzida) };
            factTypeFormDemonstratesDesignation ftfdd = new factTypeFormDemonstratesDesignation() { factTypeForm1 = sf.id, designation1 = pVerb };
            designation d = new designation() { id = idVerb, signifier = String.Concat(idVerb, "-t"), meaning = sf.meaning };
            text t1 = new text() { id = sf.expression, value = pFact };
            text t2 = new text() { id = d.signifier, value = pVerb };

            xml += Serialize<sententialForm>(sf);
            xml += Serialize<factType>(ft);
            xml += Serialize<factTypeFormDemonstratesDesignation>(ftfdd);
            xml += Serialize<designation>(d);
            xml += Serialize<text>(t1);
            xml += Serialize<text>(t2);

            placeholder p = null;
            placeholderUsesDesignation pud = null;
            concept1SpecializesConcept2 csc = null;
            factTypeRole ftr = null;
            positiveInteger pi = null;
            int i = 1;
            foreach (KeyValuePair<String, String> item in dicSerialization)
            {
                p = new placeholder() { id = String.Format("{0}-p{1}", idReduzida, i), expression = String.Concat(item.Key, "-t"), startingCharacterPosition = new String[] { String.Concat("i", pFact.IndexOf(item.Value) + 1) }, meaning = String.Format("{0}-r{1}", idReduzida, i) };
                pud = new placeholderUsesDesignation() { placeholder1 = p.id, designation1 = item.Key };
                csc = new concept1SpecializesConcept2() { concept11 = p.meaning, concept21 = String.Concat(item.Key, "-c") };
                ftr = new factTypeRole() { id = p.meaning };
                pi = new positiveInteger() { id = p.startingCharacterPosition[0], value = p.startingCharacterPosition[0].Substring(1) };

                xml += Serialize<placeholder>(p);
                xml += Serialize<placeholderUsesDesignation>(pud);
                xml += Serialize<concept1SpecializesConcept2>(csc);
                xml += Serialize<factTypeRole>(ftr);
                xml += Serialize<positiveInteger>(pi);

                i++;
            }

            return xml;
        }
    }
}