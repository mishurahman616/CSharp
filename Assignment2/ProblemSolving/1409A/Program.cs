// Solution to the codeforces problem - 1409A-Yet Another Two Integers Problem

int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    var data = Console.ReadLine().Trim().Split().Select(s => Convert.ToInt32(s)).ToList();
    var dif = Math.Abs(data[0] - data[1]);
    Console.WriteLine(Math.Ceiling(dif / 10.0));
}