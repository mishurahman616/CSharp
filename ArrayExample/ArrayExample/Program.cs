using System.Diagnostics;
using System.Diagnostics.Metrics;

class Program
{
    private static void Main(string[] args)
    {
        //Single Dimensional Array
        int[] ages = new int[5];
        for(int i = 0; i < ages.Length; i++)
        {
            ages[i] = i;
        }
        foreach(int age in ages)
        {
            Console.WriteLine(age);
        }
        Console.WriteLine("\nPrinting Dates");
        DateTime[] dates = new DateTime[5];
        for(int i=0; i < dates.Length; i++)
        {
            dates[i] = DateTime.Now;
        }
        foreach(DateTime date in dates)
        {
            System.Console.WriteLine(date); 
        }

        //MultiDimensional Array
        int[,] positions = new int[3, 5];
        Console.WriteLine(positions.Length);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                positions[i,j] = i + j;
            }
        }


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(positions[i,j]+"\t");
            }
            Console.WriteLine();
        }



        //Jagged array 
        int[][] grades = new int[3][];
        int counter = 0;
        for( int i = 0; i < 3; i++)
        {
            grades[i] = new int[i+1];
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                grades[i][j] = counter++;
            }
           
        }
        Console.WriteLine($"\nLength of jagged array grade[{grades.Length}][] is "+grades.Length);
        Console.WriteLine("Printing Jaged array");
        for (int i= 0; i < 3; i++)
        {
            for(int j=0; j<i+1; j++)
            {
                Console.Write(grades[i][j] + "\t");
            }
            Console.WriteLine();
        }
    


    }
}