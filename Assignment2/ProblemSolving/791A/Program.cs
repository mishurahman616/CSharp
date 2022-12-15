// Solution to the codeforces problem - 791A-Bear and Big Brother
using System.Diagnostics.Metrics;
var lb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int counter = 0;
while (lb[1] >= lb[0])
{
    lb[0] *= 3;
    lb[1] *= 2;
    counter++;
}
Console.WriteLine(counter);