// Solution of the codefoces problem 200B-Drinks
int n = Convert.ToInt32(Console.ReadLine());
var data = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
int sum = 0;
foreach(var item in data)
{
    sum += item;
}
Console.WriteLine(((sum*1.0)/n).ToString("0.000000000000"));