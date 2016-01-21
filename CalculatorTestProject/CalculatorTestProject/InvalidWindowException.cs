using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestSuite
{
    public class InvalidWindowException : Exception
    {
        public InvalidWindowException()
        {

        }

        public InvalidWindowException(string exceptionMassage, string actualWindowTitle, string expectedWindowTitle)
            : base(exceptionMassage)
        {

        }
    }
}
