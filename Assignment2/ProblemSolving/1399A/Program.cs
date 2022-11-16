// Solution to the codefoces problem 1399A-Remove Smallest
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Sort(a);
    bool possible = true;
    for(int j=0; j<n-1; j++)
    {
        if(Math.Abs(a[j]-a[j+1])>1)
        {
            possible = false;
            break;
        }

    }
    if (possible)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}