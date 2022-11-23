// Solution to the codeforces problem - 486A-Calculating function
long x = Convert.ToInt64(Console.ReadLine().Trim());
long halfX = x>>1;
if (x % 2 == 0)
{
    Console.WriteLine(halfX);
}
else
{
    Console.WriteLine((halfX-x));
}
