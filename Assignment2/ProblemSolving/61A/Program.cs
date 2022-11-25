// Solution to the codeforces problem - 61A-Ultra-Fast Mathematician

string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
for(int i=0; i<s1.Length; i++)
{
    if (s1[i] == s2[i])
    {
        Console.Write("0");
    }
    else
    {
        Console.Write("1");
    }
}
