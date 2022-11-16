// Solution to the codefoces problem 263A-Beutiful Matrix
int[][] matrix = new int[5][];
for(int i=0; i<5; i++)
{
    matrix[i] = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
}

for(int i=0; i<5; i++)
{
    for(int j=0; j<5; j++)
    {
        if (matrix[i][j] == 1) {
            Console.WriteLine(Math.Abs(2-i)+Math.Abs(2-j));
            break;
        }
    }
}