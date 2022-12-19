// Solution to the codeforces problem - 1230A-Dawid and Bags of Candies

var data=Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
 Array.Sort(data);

int sum1 = data[3], sum2 = data[2];
int x = 2;
while (--x>=0)
{
    if (sum1 > sum2)
    {
        sum2 += data[x];
    }
    else
    {
        sum1 += data[x];
    }

}
Console.WriteLine(sum1 == sum2?"YES":"NO");
