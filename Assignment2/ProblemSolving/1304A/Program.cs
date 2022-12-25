// Solution to the codeforces problem - 1304A-Two Rabbits
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var xyab = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
    int common = 0;
    double commonPoint = (double)(xyab[1] - xyab[0])/ (xyab[2] + xyab[3]);
    common = (int)commonPoint;
    if (common == commonPoint)
    {
        Console.WriteLine(common);
    }
    else
    {
        Console.WriteLine(-1);
    }
}