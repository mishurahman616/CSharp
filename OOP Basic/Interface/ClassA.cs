﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class ClassA:IInterface
    {
        public void MethodA() => Console.WriteLine("Mehtod A");

        public void InterfaceImplementation()
        {
            Console.WriteLine("From method Implementation");
        }

        public string Name { get; set; }
    }
}
