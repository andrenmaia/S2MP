using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S2MP.Console2.Common;

namespace S2MP.Console2.CommandHandler
{
    /// <summary>
    /// Represents types of commands.
    /// </summary>
    internal abstract class InputCommand
    {

        #region Properties

        /// <summary>
        /// String user input.
        /// </summary>
        public string[] Input { get; set; }

        /// <summary>
        /// Current invoker.
        /// </summary>
        public InputCommandInvoker MyInvoker { get; protected set; }

        #endregion

        #region Contructors

        /// <summary>
        /// Default constructor for InputCommand.
        /// </summary>
        /// <param name="invoker">
        /// Reference invoker handler.
        /// </param>
        public InputCommand(InputCommandInvoker invoker)
        {
            this.MyInvoker = invoker;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Execute the command.
        /// </summary>
        internal abstract void Execute();


        /// <summary>
        /// Unexecute the command.
        /// </summary>
        internal abstract void UnExecute();
     
        #endregion
    }
}
