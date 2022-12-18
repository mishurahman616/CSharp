// Solution to the codeforces problem - 977A-Wrong Subtraction
var nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

while (nk[1]-- >=1)
{
    if (nk[0] % 10 == 0)
    {
        nk[0] /= 10;
    }
    else
    {
        nk[0]--;
    }
}
Console.WriteLine(nk[0]);
