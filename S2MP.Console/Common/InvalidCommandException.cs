using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace S2MP.Console2.Common
{
    class InvalidCommandException : Exception
    {
        public InvalidCommandException()
        {

        }
        public InvalidCommandException(string message)
            : base(message)
        {

        }
    }
}
