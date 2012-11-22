using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Management;

namespace S2MP.Console2.CommandHandler
{
    class SetupCommand : InputCommand
    {
        public SetupCommand(InputCommandInvoker invoker)
            : base(invoker)
        {
        }

        internal override void Execute()
        {
            string pathXmi = Input[1].Replace("\"", string.Empty);
            string pathTemplates = Input[2].Replace("\"", string.Empty);
            string languageResult = Input[3].Replace("\"", string.Empty);

            ISetup st = new Setup(pathXmi, pathTemplates, (Model.Languages)Enum.Parse(typeof(Model.Languages), languageResult));

            MyInvoker.SetNewSetup(st);


            Console.WriteLine("Setup applied.");

        }
        internal override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
