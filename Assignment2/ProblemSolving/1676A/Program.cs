// Solution to the codefores problem - 1676A-Lucky?

int n = Convert.ToInt32(Console.ReadLine());
for(int j = 0; j < n; j++)
{
    string s = Console.ReadLine();
    int sum1=0, sum2=0;
    for(int i=0; i<3; i++)
    {
        sum1 += Convert.ToInt32(s[i]);
        sum2 += Convert.ToInt32(s[i + 3]);
    }

    if (sum1 == sum2)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

