// Solution to the codeforces problem - 723A-he New Year: Meeting Friends
var x = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToList();
x.Sort();
Console.WriteLine($"{x[2] - x[0]}"); //
