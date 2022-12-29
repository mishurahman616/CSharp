// Solution to the codeforces problem -405A-Gravity Flip

int n = Convert.ToInt32(Console.ReadLine());
var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Array.Sort(data);
foreach(var item in data)
{
    Console.Write(item+" ");
}