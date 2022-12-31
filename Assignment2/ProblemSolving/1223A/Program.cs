// Solution to the codeforces problem 1223A-CME
int q = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < q; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 4)
    {
        Console.WriteLine(4 - n);
    }else if(n%2== 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        Console.WriteLine(1);
    }
}
