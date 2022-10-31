using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingExceptions
{
    public class ExampleClass : Exception
    {
        public ExampleClass(string aMessage) : base(aMessage)
        {

        }
    }
}
// Custom exception class
