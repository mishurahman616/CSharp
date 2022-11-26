// Solution to the codeforces problem - 158A-Next Round
var nk = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
var data = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToArray();
int kth = Convert.ToInt32(data[nk[1]-1]);
int counter = 0;
foreach(var item in data)
{
    if(item>=kth && item > 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);