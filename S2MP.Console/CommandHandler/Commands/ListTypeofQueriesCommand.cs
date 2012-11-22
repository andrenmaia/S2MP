using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Console2.CommandHandler
{
    class ListTypeofQueriesCommand : InputCommand
    {

        public ListTypeofQueriesCommand(InputCommandInvoker invoker)
            : base(invoker)
        {

        }

        internal override void Execute()
        {
            StringBuilder buffer = new StringBuilder();

            buffer.AppendLine("Queries:")
                .AppendLine("\t - SemanticFormulation")
                .AppendLine("\t - LogicalFormulation")
                .AppendLine("\t - Projection");

            Console.WriteLine(buffer);
        }

        internal override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
