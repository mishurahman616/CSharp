// Solution to the codeforces problem 155A-I_love_%username%
int n = Convert.ToInt32(Console.ReadLine());

var data = Console.ReadLine().Trim().Split().Select(x => Convert.ToInt32(x)).ToList();
int max = data[0];
int min = data[0];
int amazing = 0;
for (int i=1; i<n; i++)
{
    if (data[i] > max)
    {
        max = data[i];
        amazing++;
    }else if (data[i] < min)
    {
        min = data[i];
        amazing++;
    }

}
Console.WriteLine(amazing);