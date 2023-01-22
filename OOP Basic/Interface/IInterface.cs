using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IInterface
    {
        public void DefaultImplementation()
        {
            Console.WriteLine("Printing Default");
        }
        public void InterfaceImplementation();
      
    }
}
