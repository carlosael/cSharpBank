using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBank.Exceptions
{
    public class FinanceOperationException : Exception
    {
        public FinanceOperationException(string message) : base(message)
        {

        }

        public FinanceOperationException(string message, Exception internalException) : base(message, internalException) 
        {

        }
    }
}
