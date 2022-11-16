// Solution to the codefoces problem 144A-Arrival of the General
int n = Convert.ToInt32(Console.ReadLine());
var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int max = int.MinValue;
int min = int.MaxValue;
int maxIndex = 0;
int minIndex = 0;
for(int i=0; i<n; i++)
{
    if (arr[i] > max)
    {
        maxIndex = i;
        max= arr[i];
    }
    if (arr[i] <= min)
    {
        minIndex = i;
        min= arr[i];
    }
}
if (maxIndex < minIndex)
{
    Console.WriteLine(maxIndex + (n - 1 - minIndex));
}
else
{
    Console.WriteLine(maxIndex +n-2 - minIndex);
}