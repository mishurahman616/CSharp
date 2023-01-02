//Delegates
using Delegates;
using static Delegates.DelegatesExample;

DelegatesExample delegates = new DelegatesExample();
Print print1 = new Print(delegates.PrintToFile);
Print print2 = new Print(delegates.PrintToConsole);

Console.WriteLine("Enter Text to Print to file: ");
print1(Console.ReadLine());
Console.WriteLine("Enter Text to Print to Console: ");
print2(Console.ReadLine());
//delegates.DoSomething(Console.WriteLine, Console.ReadLine());
