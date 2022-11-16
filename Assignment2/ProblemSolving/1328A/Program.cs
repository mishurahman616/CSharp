// Solution to the codeforces problem 1328A - Divisibility Problem
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var move = data[1] - (data[0] % data[1]);
    Console.WriteLine(move == data[1]?0:move);
}