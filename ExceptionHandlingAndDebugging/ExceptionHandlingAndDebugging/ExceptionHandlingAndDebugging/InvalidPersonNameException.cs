using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAndDebugging
{
    public class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string message)
           : base(message)
        {
        }
    }
}
