// Solution of the codefoces problem 1367A-Short Substrings
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    string b = Console.ReadLine();
    Console.Write(b[0]);
    for(int j = 1; j < b.Length-1; j+=2)
    {
        Console.Write(b[j]);
    }
    Console.WriteLine(b[b.Length-1]);
}