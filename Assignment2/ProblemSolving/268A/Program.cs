// Solution to the codeforces problem 268A-Games
int n = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int[,] hg = new int[n, 2];
for (int i = 0; i< n; i++)
{
    var data = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
    (hg[i, 0], hg[i, 1]) = (data[0], data[1]);
}
for(int i=0; i<n; i++)
{
    for(int j=0; j<n; j++)
    {
        if (hg[i, 0] == hg[j, 1])
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);