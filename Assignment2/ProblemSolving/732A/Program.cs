// Solution to the codeforces problem - 732A-Buy a Shovel

var x = Console.ReadLine().Trim().Split().Select(s=>Convert.ToInt32(s)).ToList();
int counter = 1;
int k = x[0];
while (!(k % 10==0 || (k - x[1]) % 10 == 0))
{
    k += x[0];
    counter++;
}

Console.WriteLine(counter);