//Solution to the codeforces problem - 1754A-Technical Support
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{

    int n = Convert.ToInt32(Console.ReadLine());
    string sequence = Console.ReadLine();
    int q = 0;
    for(int j=0; j<n; j++)
    {

        if (sequence[j] == 'Q')
        {
            q++;
        }
        else
        {
            if (q > 0)
            {
                q--;
            }
        }

    }
    if(q<=0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}