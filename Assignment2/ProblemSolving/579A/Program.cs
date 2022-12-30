// Solution to the codeforces problem -579A-Raising Bacteria
int n = Convert.ToInt32(Console.ReadLine());
int bacteriaCounter = 0;
while(n > 0)
{
    if (n % 2 == 0)
    {
        n /= 2;
    }
    else
    {
        n = (n-1) / 2;
        bacteriaCounter++;
    }
}
Console.WriteLine(bacteriaCounter);