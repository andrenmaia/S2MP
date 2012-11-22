using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Management;

namespace S2MP.Console2.CommandHandler
{
    class CurrentSetupCommand : InputCommand
    {

        public CurrentSetupCommand(InputCommandInvoker invoker)
            : base(invoker)
        {

        }
        internal override void Execute()
        {
            if (Manager.CurrentSetup == null)
            {
                Console.WriteLine("Current setup is not set.");
                return;
            }

            StringBuilder buffer = new StringBuilder();
            buffer.AppendLine("Current setup:")
                .Append("\t - XmiPath:").AppendLine(Manager.CurrentSetup.XmiPath)
                .Append("\t - TemplatesPath:").AppendLine(Manager.CurrentSetup.TemplatesPath)
                .Append("\t - Language:").AppendLine(Manager.CurrentSetup.DefaultLanguageOfQueryResult.ToString());


            Console.WriteLine(buffer);
        }

        internal override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
