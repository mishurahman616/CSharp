// Solution to the codeforces problem - 50A-Domino piling
var xy = Console.ReadLine().Trim().Split().ToList().Select(x => Convert.ToInt32(x)).ToList();
Console.WriteLine(xy[0] * xy[1]/2);
