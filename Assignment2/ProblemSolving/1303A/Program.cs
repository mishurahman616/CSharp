// Solution to the codeforces problem - 1303A-Erasing Zeroes
int n = Convert.ToInt32(Console.ReadLine());
for(int j=0; j < n; j++)
{
    string s = Console.ReadLine();
    string s1=s.Trim('0');
    
    int zeroCounter = 0;
    for (int i = 0; i < s1.Length; i++)
    {
        if (s1[i] == '0')
        {
            zeroCounter++;
        }
    }

    Console.WriteLine(zeroCounter);
}