// Solution to the codeforcs problem 472A-Design Tutorial: Learn from Math
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"{4} {n - 4}");
}
else
{
    Console.WriteLine($"{9} {n-9}");
}
