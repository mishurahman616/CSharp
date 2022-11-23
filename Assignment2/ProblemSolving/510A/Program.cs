//Solution to the codeforces problem-510A-Fox and Snake

var nm = Console.ReadLine().Split().ToList().Select(s => Convert.ToInt32(s)).ToList();
bool startSharp = false;
bool endSharp = true;
for(int i=0; i < nm[0]; i++)
{
    for(int j=0; j < nm[1]; j++)
    {
        if (i % 2 == 0)
        {
            if (j == nm[1] - 1)
            {
                Console.WriteLine("#");
            }
            else
            {
                Console.Write("#");
            }


        }
        else
        {
            if(j==0 && startSharp)
            {
                Console.Write("#");
                startSharp = false;
            }
            else if (j == nm[1]-1 && !startSharp && endSharp)
            {
                Console.WriteLine("#");
                startSharp= true;
                endSharp= false;
            }else if (j == nm[1] - 1)
            {
                Console.WriteLine(".");
                endSharp = true;
            }
            else
            {
                Console.Write(".");
            }
        }

    }
}
