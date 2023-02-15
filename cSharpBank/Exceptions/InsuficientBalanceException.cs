using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBank.Exceptions
{
    public class InsuficientBalanceException : Exception
    {
        public InsuficientBalanceException(string message) : base(message)
        { 

        }
    }
}
