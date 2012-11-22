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
using S2MP.Xmi;
using S2MP.Query;
using S2MP.Model;
using S2MP.Management;
using S2MP.Command;
using S2MP.Console2.Common;
using System.Threading.Tasks;

namespace S2MP.Console2
{
    class Program
    {
        static void Main(string[] args)
        {

            ///
            /// Cleanup, print header, parse the command and execute it.
            /// 

            var handler = new InputCommandInvoker();

            // Task.Factory.StartNew(() => handler.KeyPressHandler());
            handler.Cleanup();
            handler.WriteHeader();


            //Template t = new Template();
            //t.Name = "Logical Formulation - At-Least-N Quantification";
            //t.QueryType = "LogicalFormulation";
            //t.QuerySubType = "AtLeastNQuantification";
            //t.Version = "1.0";
            //t.Language = Languages.Csharp;
            //t.Parameters = new List<Parameter>();

            //t.Parameters.Add(new Parameter() { Name = "@@entityA@@", IsInput = true });
            //t.Parameters.Add(new Parameter() { Name = "@@entityB@@", IsInput = true });
            //t.Parameters.Add(new Parameter() { Name = "@@n@@", IsInput = false });
            //t.TextTemplateToParse = "	if (this.@@entityB@@Collection.Count &lt; @@n@@)	{		throw new AtLeastNQuantificationException(\"A quantidade de @@entityB@@ em @@entityA@@ deve ser maior que @@n@@.\");	}";


            //XmlSerializer s = new XmlSerializer(typeof(Template));
            //s.Serialize(File.Create(@"C:\temp\f.xml"), t);

            do
            {
                try
                {
                    handler.GetCommandFromConsole();
                    if (handler.IsValidLastInputCommand)
                        handler.ExecuteLastCommand();
                }
                catch (InvalidCommandException) { }
                catch (InvalidInputException ipex)
                {
                    Console.WriteLine(ipex.Message);
                }
                catch (InvalidCommandInputException ipex)
                {
                    Console.WriteLine(ipex.Message);
                }

            } while (!handler.IsShutdown);

            Console.Read();
        }
    }
}