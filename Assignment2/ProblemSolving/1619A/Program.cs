// Solution of the codefoces problem 1619A- Square Stirng
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    string s = Console.ReadLine();
    if (s.Length % 2 == 0)
    {
        int mid = s.Length/ 2-1;
        int last = s.Length-1;
        bool isSquare = true;
        for(int j=0; j<s.Length/2; j++)
        {
            if (s[mid--] != s[last--])
            {
                Console.WriteLine("NO");
                isSquare = false;
                break;
            }

        }
        if (isSquare)
        {
            Console.WriteLine("Yes");
        }
    }
    else
    {
        Console.WriteLine("NO");
    }
}

