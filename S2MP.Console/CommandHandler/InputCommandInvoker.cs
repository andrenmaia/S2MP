using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Console2.Common;
using S2MP.Console2.CommandHandler;
using S2MP.Management;

namespace S2MP.Console2
{

    /// <summary>
    /// Default invoker for console commands.
    /// </summary>
    internal class InputCommandInvoker
    {
        #region Attributes

        /// <summary>
        /// Index of the last command added;
        /// </summary>
        int _commandCounter;

        #endregion

        #region Properties

        /// <summary>
        /// True if the input command is shutdonw, otherwise false.
        /// </summary>
        public bool IsShutdown { get; private set; }

        /// <summary>
        /// List with the last inputcommand. 
        /// </summary>
        public List<InputCommand> InputCommandsCollection { get; private set; }


        /// <summary>
        /// True if the last input command is valid, otherwise false.
        /// </summary>
        public bool IsValidLastInputCommand { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Create a default InputConsoleInvoker (Cleanup is performed).
        /// </summary>
        public InputCommandInvoker()
        {
            Cleanup();
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
        }

        /// <summary>
        /// Handle cancel key press.
        /// </summary>
        void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("\t session end:{0}{1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), Environment.NewLine);
            IsShutdown = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get (wait user input) command from console.
        /// </summary>
        internal void GetCommandFromConsole()
        {
            if (IsShutdown)
                return;

            this.WriteLineHeader();
            // ConsoleKeyInfo keyPressed = Console.ReadKey();

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                IsValidLastInputCommand = false;
                return;
            }

            string[] userInput = input.Split(' ');
            InputCommand newCommand = InputCommandFactory.FactoryMethod(userInput, this);
            AddCommand(newCommand);

            IsValidLastInputCommand = true;
        }


        /// <summary>
        /// Execute the last command inputed by user, if any.
        /// </summary>
        internal void ExecuteLastCommand()
        {
            if (_commandCounter < 0)
                throw new InvalidCommandException("There are no commands to execute.");

            InputCommandsCollection[_commandCounter].Execute();
        }

        /// <summary>
        /// Add a new command and ajust the command counter.
        /// </summary>
        /// <param name="newCommand">
        /// A new command to add.
        /// </param>
        private void AddCommand(InputCommand newCommand)
        {
            InputCommandsCollection.Add(newCommand);
            _commandCounter = InputCommandsCollection.Count - 1;
        }


        /// <summary>
        /// Remove a command and ajust the command counter.
        /// </summary>
        /// <param name="removeCommand">
        /// A command to remove.
        /// </param>
        private void RemoveCommand(InputCommand removeCommand)
        {
            InputCommandsCollection.Remove(removeCommand);
            _commandCounter = InputCommandsCollection.Count - 1;
        }


        /// <summary>
        /// Write a line header for console.
        /// </summary>
        private void WriteLineHeader()
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("s2mp>");
        }

        /// <summary>
        /// Write a header for console.
        /// </summary>
        internal void WriteHeader()
        {
            StringBuilder head = new StringBuilder();
            head.AppendLine("Console S2MP - version 1.0.");
            head.AppendLine("SBVR to MDA Parser - Enables the integration between SBVR and MDA.");
            head.AppendLine(string.Empty);
            head.AppendLine("Copyright (c) 2012 André Maia and Lucas Rosinelli.");
            head.AppendLine(string.Empty);
            head.AppendLine("All rights reserved.");
            head.AppendLine(string.Empty);
            head.AppendLine(" - Type -h to help;");
            head.AppendLine(" - Ctrl+C to exit.");
            
            Console.WriteLine(head);
        }

        /// <summary>
        /// Cleanup console.
        /// </summary>
        internal void Cleanup()
        {
            // Console clear.
            Console.Clear();

            // Reset counter
            _commandCounter = -1;

            // Clear commands.
            if (InputCommandsCollection == null)
                InputCommandsCollection = new List<InputCommand>();
            else
                InputCommandsCollection.Clear();
        }

        /// <summary>
        /// Set a new setup.
        /// </summary>
        /// <param name="setup">
        /// A new setup to set.
        /// </param>
        internal void SetNewSetup(S2MP.Management.ISetup setup)
        {
            Manager.SetupManager(setup);
            
        }

        #endregion


    }
}
