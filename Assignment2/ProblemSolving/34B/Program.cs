//Solution to the codeforces problem - 34B-Sale
var data1 = Console.ReadLine().Trim().Split(' ').Select(s => Convert.ToInt32(s)).ToList();
var data = Console.ReadLine().Trim().Split().Select(s=>Convert.ToInt32(s)).ToArray();
Array.Sort(data);
int sum = 0;
for(int i=0; i < data1[1]; i++)
{
    if (data[i]<0)
    sum += Math.Abs(data[i]);
}

Console.WriteLine(sum);