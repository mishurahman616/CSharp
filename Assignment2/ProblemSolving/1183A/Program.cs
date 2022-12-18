// Solution to the codeforces problem - 1183A-Nearest Interesting Number

int n = Convert.ToInt32(Console.ReadLine());
int x = n;
int sum = 0;
while (x > 0)
{
    sum += x % 10;
    x /= 10;
}

while(sum%4 != 0)
{
    n = n + 1;
     x = n;
     sum = 0;
    while (x > 0)
    {
        sum += x % 10;
        x /= 10;
    }
}
Console.WriteLine(n);