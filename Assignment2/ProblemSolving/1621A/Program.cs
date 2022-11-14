//Solution of the codeforces problem 1621A-Stable Arrangement of Rooks
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int n = x[0], k = x[1];
    if (Math.Ceiling(n / 2.0) < k)
    {
        Console.WriteLine(-1);
    }
    else
    {
        int RPlace = 0;
        int RPlaced = 0;
        for(int row=0; row<n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (RPlace == row && RPlace == col && RPlaced<k)
                {
                    Console.Write("R");
                    RPlace += 2;
                    RPlaced++;
                }else
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }

}
