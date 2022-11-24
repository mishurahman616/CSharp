// Solution to the codeforces problem - 758A-Holiday Of Equality
int n = Convert.ToInt32(Console.ReadLine().Trim());
var treasury = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToList();
long sum = 0;
int max = treasury.Max();
for(int i=0; i<treasury.Count; i++)
{
    sum+= max-treasury[i];
}
Console.WriteLine(sum);