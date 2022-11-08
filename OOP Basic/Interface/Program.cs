// See https://aka.ms/new-console-template for more information

using Interface;

ClassC c = new ClassC();
IInterface ca = new ClassA();
c.methodA();

ca.DefaultImplementation();
ca.InterfaceImplementation();