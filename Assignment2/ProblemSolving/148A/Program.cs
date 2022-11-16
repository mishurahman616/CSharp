// Solution to the codefoces problem 148A-Insomnia cure

int k0 = Convert.ToInt32(Console.ReadLine());
int l0 = Convert.ToInt32(Console.ReadLine());
int m0 = Convert.ToInt32(Console.ReadLine());
int n0 = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int[] klmn= new int[] {k0, l0, m0, n0};
bool[] arr = new bool[d+1];
int counter = 0;
for(int i = 0; i < 4; i++)
{
        for(int j = klmn[i]; j<=d; j += klmn[i])
        {
            arr[j]= true;
        }
}
for(int i = 1; i<=d; i++)
{
    if (arr[i]==true)
    {
        counter++;

    }
}

Console.WriteLine(counter);
