using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Model
{
    public class TemplateParseException: Exception
    {
        public string Parameter { get; private set; }
        public string TextTemplateToParse { get; private set; }

        public TemplateParseException(string parameter, string textTemplateToParse)
        {
            this.Parameter = parameter;
            this.TextTemplateToParse = textTemplateToParse;
        }
    }
}
