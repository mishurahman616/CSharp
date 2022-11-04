//Solution of the codeforces problem 1154A - Restoring Three Numbers


int[] x =  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(x);
Console.WriteLine($"{x[3] - x[0]} {x[3] - x[1]} {x[3] - x[2]}");