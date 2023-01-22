//four types of loop

//for loop
using System.Collections.Immutable;

Console.WriteLine("For loop Example");
for(int i=0; i<10; i++)
{
    Console.Write($"{i} ");
}

//while looop
Console.WriteLine("\nWhile loop Example");
int j = 0;
while (true)
{
    Console.Write($"{j++} ");
    if (j == 10) break;
}


//do while looop
Console.WriteLine("\nDo While loop Example");
do
{
    Console.Write($"{j++} ");
    if (j == 10) break;
} while (false);


//foreach looop
Console.WriteLine("\nForeach loop Example");
int[] k = new int[10];
foreach(int i in k)
{
    Console.WriteLine(i);
}


