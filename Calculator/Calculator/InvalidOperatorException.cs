using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class InvalidOperatorException : Exception
    {
        public InvalidOperatorException(string operatorString) : base(string.Format("The operation {0} will not work.", operatorString))
        {

        }
    }
    
}
