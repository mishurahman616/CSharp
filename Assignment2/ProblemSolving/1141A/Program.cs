// Solution to the codeforces problem - 1141A-Game 23
var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int counter = 0;
if (data[0] == data[1])
{
    Console.WriteLine(0);
}
else if (data[1] % data[0] != 0)
{
    Console.WriteLine(-1);
}
else
{
    int d = data[1] / data[0];
    while (d %2==0)
    {
        d /= 2;
        counter++;
    }
    while (d % 3 == 0)
    {
        d /= 3;
        counter++;
    }
    if (d == 1)
    {
        Console.WriteLine(counter);
    }
    else
    {
        Console.WriteLine(-1);
    }
}

