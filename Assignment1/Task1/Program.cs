Console.Write("Enter the length of the array: ");
int arrayLength = Int16.Parse(Console.ReadLine());
int[] sum = new int[2 * arrayLength + 2];
if (arrayLength >= 3 && arrayLength <= 1000)
{
    int[,] arr = new int[arrayLength, arrayLength];
    
    //Taking input array element 
    for(int row= 0; row < arrayLength; row++)
    {
        for(int col= 0; col < arrayLength; col++)
        {
            Console.Write($"\nEnter the array element array[{row},{col}]: ");
            arr[row,col] = int.Parse(Console.ReadLine());
        }
    }

    //Calculating sum
    for (int row = 0; row < arrayLength; row++)
    {
        for (int col = 0; col < arrayLength; col++)
        {
            sum[row] += arr[row, col];
            sum[arrayLength + col] += arr[row, col];
            if (row == col)
            {
                sum[^2] += arr[row, col];
            }
            if (row == (arrayLength - 1) - col)
            {
                sum[^1] += arr[row, col];
            }
        }
    }

    //Finding maximum sum
    int max = int.MinValue;
    foreach(int i in sum)
    {

        if (i > max)
        {
            max = i;
        }
    }
    Console.WriteLine($"Maximum sum is {max}.");
}