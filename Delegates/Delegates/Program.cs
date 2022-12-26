//Delegates
using Delegates;
using static Delegates.DelegatesExample;

DelegatesExample delegates = new DelegatesExample();
Print print1 = new Print(delegates.PrintToFile);
Print print2 = new Print(delegates.PrintToConsole);

print1(Console.ReadLine());
print2(Console.ReadLine());