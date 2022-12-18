// Solution to the codeforces problem - 546A-Soldier and Bananas

var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int x = data[2] * (data[2] + 1) / 2 * data[0] - data[1];
Console.WriteLine(x > 0 ? x : 0);