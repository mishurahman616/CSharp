// See https://aka.ms/new-console-template for more information
using Events;

Console.WriteLine("Hello, World!");

Button button = new Button();
int a = 5;
button.OnClick += (a)=>Console.WriteLine(Console.ReadLine());
button.OnClick += (a) => Console.WriteLine(Console.ReadLine()+"Abcd");
button.ClickButton();