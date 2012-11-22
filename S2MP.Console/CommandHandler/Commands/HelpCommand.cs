using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Console2.CommandHandler
{
    class HelpCommand : InputCommand
    {
        public HelpCommand(InputCommandInvoker invoker)
            : base(invoker)
        {

        }

        internal override void Execute()
        {
            Console.WriteLine(Environment.NewLine);

            StringBuilder helpText = new StringBuilder();
            helpText.AppendLine("-st [--setup] \"pathXmi\" \"pathTemplates\" \"LanguageResult\"");
            helpText.AppendLine("-cst [--currentSetup] ");
            helpText.AppendLine("-qt [--queryType] \"nameQueryType\" -p [--params] \"entityA\" \"entityB\"");
            helpText.AppendLine("-lq [--getTypeofQueries]");
            helpText.AppendLine("-h [--help]");
            helpText.AppendLine("Ctrl+C to exit.");

            Console.WriteLine(helpText);
        }

        internal override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
