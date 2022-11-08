// See https://aka.ms/new-console-template for more information

using Interface;

ClassC c = new ClassC();
IInterface ca = new ClassA();
c.methodA();
c.methodB();

ca.DefaultImplementation();
ca.InterfaceImplementation();