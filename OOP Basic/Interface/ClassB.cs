using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ClassB:ClassA
    {
        public void methodB()
        {
            Console.WriteLine("From B");
        }
        public new void methodA()
        {
            Console.WriteLine("From BA");
        }
    }
}
