// Solution to the codefoces problem 1312A-Two Regular Polygons
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var data = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
    if (data[0] % data[1] == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
