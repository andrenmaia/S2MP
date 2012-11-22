using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Command;

namespace S2MP.Console2.CommandHandler
{
    class QueryTypeCommand : InputCommand
    {

        public QueryTypeCommand(InputCommandInvoker invoker)
            : base(invoker)
        {

        }

        internal override void Execute()
        {

            string queryType = Input[1].Replace("\"", string.Empty) + "Query";
            string entityA = Input[3].Replace("\"", string.Empty);
            string entityB = Input[4].Replace("\"", string.Empty);

            // Console.WriteLine("{0} - {1}, {2}", queryType, entityA, entityB);

            S2MPCommand cmd = new S2MPCommand();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("entityA", entityA);
            param.Add("entityB", entityB);

            int i = 0;

            var results = cmd.ExecuteQuery(queryType, param);

            Console.WriteLine(Environment.NewLine);
            foreach (var item in results)
            {
                
                Console.WriteLine("Result:{0} =================================", ++i);
                Console.WriteLine();
                Console.WriteLine(item.Result);
                Console.WriteLine("==========================================");
            }
            Console.WriteLine("Count:{0}", results.Count);
        }

        internal override void UnExecute()
        {
            throw new NotImplementedException();
        }
    }
}
