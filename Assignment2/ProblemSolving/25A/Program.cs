//Solution to the codeforces problem - 25A-IQ test
int n = Convert.ToInt32(Console.ReadLine());
var data = Console.ReadLine().Trim().Split().Select(s => Convert.ToInt32(s)).ToList();
int evenCounter = 0;
int oddCounter = 0;
int evenIndex =-1;
int oddIndex = -1;
for(int i=0; i<n; i++)
{

    if (data[i] % 2 == 0)
    {
        evenCounter++;

        evenIndex = i;
    }
    if (data[i]%2 != 0)
    {
        
        oddCounter++;

        oddIndex = i;
    }

    if (evenCounter > 1 && oddIndex > -1)
    {
        Console.WriteLine(oddIndex + 1);
        break;
    }
    if (oddCounter > 1 && evenIndex > -1)
    {
        Console.WriteLine(evenIndex + 1);
        break;
    }
}