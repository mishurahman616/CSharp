// Solution to the codefoces problem 1354A-Alarm Clock

int t = Convert.ToInt32(Console.ReadLine());
for(int i=0; i<t; i++)
{
    var data = Console.ReadLine().Trim().Split().Select(s => Convert.ToInt32(s)).ToList();
    if (data[0] <= data[1])
    {
        Console.WriteLine(data[1]);
    }else if (data[3] >= data[2])
    {
        Console.WriteLine(-1);
    }
    else
    {
        int diff = data[2] - data[3];

        int count = (int)Math.Ceiling((double)(data[0] - data[1]) / diff);
        Console.WriteLine((decimal) count * data[2] + data[1]);
    }
}