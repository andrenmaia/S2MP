using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2MP.Common
{
    internal class Constants
    {

        //http://www.omg.org/spec/SBVR/20070901/MeaningAndRepresentation-model.xml
        //http://www.omg.org/spec/SBVR/20070901/LogicalFormulationOfSemantics-model.xml
        //http://www.omg.org/spec/SBVR/20070901/DescribingBusinessVocabularies-model.xml
        //http://www.omg.org/spec/SBVR/20070901/DescribingBusinessRules-model.xml
        //http://www.omg.org/spec/SBVR/20070901/SBVR-model.xml


        public const String XmiPrefix = "xmi";
        public const String XmiNamespace = "http://schema.omg.org/spec/XMI/2.1";
        public const String SbvrPrefix = "sbvr";
        public const String SbvrNamespace = "http://www.omg.org/spec/SBVR/20070901/SBVR.xml";
        public const String ElementNameXmi = "XMI";
        public const String TypeNameDesignation = "designation";
        public const String TypeNameObjectType = "objectType";
        public const String TypeNameText = "text";
        public const String AttributeNameVersion = "version";
        public const String AttributeNameId = "id";
        public const String AttributeNameSignifier = "signifier";
        public const String AttributeNameMeaning = "meaning";
        public const String AttributeNameValue = "value";
    }
}