using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Console2.Common
{
    class InvalidCommandInputException : Exception
    {

        public InvalidCommandInputException()
            : base()
        {
        }

        public InvalidCommandInputException(string message)
            : base(message)
        {

        }
    }
}
