// Solution to the codeforces problem - 581A-Vasya the Hipster
var x = Console.ReadLine().Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
int max = x.Max();
int min = x.Min();
Console.WriteLine($"{min} {(max-min)/2}");
