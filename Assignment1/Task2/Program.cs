Console.Write("How many numbers are there? ");
int n = int.Parse(Console.ReadLine());
int largest = int.MinValue, secondLargest = int.MinValue, thirdLargest = int.MinValue;
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number > largest)
    {
        thirdLargest = secondLargest;
        secondLargest = largest;
        largest = number;
    }
    if (number > secondLargest && number < largest)
    {
        thirdLargest = secondLargest;
        secondLargest = number;
    }
    if (number > thirdLargest && number < secondLargest)
    {
        thirdLargest = number;
    }
}

if(thirdLargest != int.MinValue)
Console.WriteLine($"Third largest number is {thirdLargest}.");

