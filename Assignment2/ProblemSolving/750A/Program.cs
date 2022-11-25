// Solution to the codeforces problem - 750A-New Year and Hurry
var data = Console.ReadLine().Trim().Split().Select(s => Convert.ToInt32(s)).ToList();
int maxTime = 240 - data[1];
int count = 0;
int time = 5;
int n = data[0];
while (time <= maxTime && n-->0)
{
    count++;
    time += (count + 1) * 5;

}
Console.WriteLine(count);