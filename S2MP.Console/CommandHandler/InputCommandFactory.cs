using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Console2.Common;

namespace S2MP.Console2.CommandHandler
{
    internal class InputCommandFactory
    {
        internal static InputCommand FactoryMethod(string[] input, InputCommandInvoker invoker)
        {
            InputCommand newCommand = null;

            // check the lengh
            if (input == null)
                throw new InvalidInputException();

            //
            // check if parameters is valid
            //


            // check setup command
            switch (input[0])
            {

                // pattern: -st [--setup] “pathXmi” “pathTemplates” “LanguageResult”
                case "-st":
                case "--setup":
                    newCommand = new SetupCommand(invoker);
                    break;


                // pattern: -qt [--queryType] “nameQueryType” -p [--params] “entityA” “entityB”
                case "-qt":
                case "--queryType":
                    newCommand = new QueryTypeCommand(invoker);
                    break;

                // pattern: -lq [--getTypeofQueries]
                case "-lq":
                case "--getTypeofQueries":
                    newCommand = new ListTypeofQueriesCommand(invoker);
                    break;

                // pattern -cst [--currentSetup]
                case "-cst":
                case "--currentSetup":
                    newCommand = new CurrentSetupCommand(invoker);
                    break;

                // pattern -h [--help]
                case "-h":
                case "--help":
                    newCommand = new HelpCommand(invoker);
                    break;


                // When the input is not valid.
                default:
                    throw new InvalidCommandInputException(
                        string.Concat("'", input[0], "' is not recognized as an command")
                    );
            }

            // check paramter order.

            if (newCommand != null)
                newCommand.Input = input;

            return newCommand;
        }
    }
}
