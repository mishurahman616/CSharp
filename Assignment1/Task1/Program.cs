using System;
Console.Write("Enter the length of the 2D array: ");
int arrayLength = Int16.Parse(Console.ReadLine());
Console.WriteLine(@"Enter array values in the format:
                                            * * * *
                                            * * * *
                                            * * * *
");
int[] sum = new int[2 * arrayLength + 2];
if (arrayLength >= 3 && arrayLength <= 1000)
{
    int[,] arr = new int[arrayLength, arrayLength];
    


    //Taking input array element 
    for(int row= 0; row < arrayLength; row++)
    {
        string[] colValues = Console.ReadLine().Split(" ");

        for(int col= 0; col < arrayLength; col++)
        {
            arr[row,col] = int.Parse(colValues[col]);
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
    int pos = 0;
    string posRowColDiagonal;
    for(int i =0; i<sum.Length; i++)
    {

        if (sum[i] > max)
        {
            max = sum[i];
            pos= i;
        }
    }

    //Finding maximum sum position
    if(pos < arrayLength)
    {
        posRowColDiagonal = "Row "+ (pos + 1);
    }else if(pos == arrayLength + arrayLength)
    {
        posRowColDiagonal = "Primary Diagonal";
    }else if(pos==arrayLength + arrayLength + 1)
    {
        posRowColDiagonal = "Secondary Diagonal";
    }
    else { 
        posRowColDiagonal = "Column " + (pos -arrayLength);
    }
    Console.WriteLine($"Maximum sum is {max} along {posRowColDiagonal}.");
}