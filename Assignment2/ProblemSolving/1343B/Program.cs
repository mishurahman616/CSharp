// Solution of the codeforces problem 1343B - Balanced Array
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    if((n/2)%2 != 0)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
        int k = n / 2;
        int even = 0;
        int odd = -1;
        int evenSum = 0;
        int oddSum = 0;
        for(int j = 0; j < k; j++)
        {
            even += 2;
            evenSum += even;
            Console.Write($"{even} " );
            
        }
        for(int j=k; j < n-1; j++)
        {
            odd += 2;
            oddSum += odd;
            Console.Write($"{odd} ");
           
        }
        Console.WriteLine(evenSum-oddSum);
    }
}
