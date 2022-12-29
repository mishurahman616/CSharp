// Solution to the codeforces problem -467A-George and Accommodation
int n = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for(int i = 0; i < n; i++)
{
    var data = Console.ReadLine().Split().Select(x=>Convert.ToInt32(x)).ToArray();
    if (data[1] - data[0] >= 2)
    {
        counter++;
    }
}
Console.WriteLine(counter);