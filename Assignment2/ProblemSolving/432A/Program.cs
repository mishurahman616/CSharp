// Solution to the codeforces problem 432A-Choosing Teams
var nk = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
var y = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
int maxLimit = 5 - nk[1];
int counter = 0;
foreach(var item in y)
{
    if(item<=maxLimit)
    {
        counter++;
    }
}
Console.WriteLine(counter/3);