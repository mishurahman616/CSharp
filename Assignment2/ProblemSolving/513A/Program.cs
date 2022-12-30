// Solution to the codeforces problem - 513A - Game
var data = Console.ReadLine().Split().Select(x=>Convert.ToInt32(x)).ToList();
if (data[0] > data[1])
{
    Console.WriteLine("First");
}
else
{
    Console.WriteLine("Second");
}
