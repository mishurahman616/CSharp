//Solution to the codefores problem - 1A-Theatre Square

var data = Array.ConvertAll(Console.ReadLine().Trim().Split(), long.Parse);

long x = (long)Math.Ceiling(data[0] * 1.0 / data[2]);
long y = (long)Math.Ceiling(data[1] * 1.0 / data[2]);
Console.WriteLine((long)(x * y));

