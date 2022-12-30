// Solution to the codeforces problem 1296A-Array with Odd Sum
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    var data = Console.ReadLine().Trim().Split().Select(s => Convert.ToInt32(s)).ToList();
    int oddCount = 0, evenCount = 0;
    for(int j=0; j<n; j++)
    {
        if (data[j]%2==0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }
    if(evenCount == data.Count || ((oddCount==data.Count)&& oddCount%2==0))
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}