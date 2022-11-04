
//Solution of the codeforces problem 443A - Anton and Letters
bool[] distinct = new bool[26];
Array.Fill(distinct, false);
string s = Console.ReadLine();
if (s.Length == 2)
{
    Console.WriteLine(0);
}
else if (s.Length == 3)
{
    Console.WriteLine(1);
}
else
{
    for (int i = 1; i < s.Length - 1; i++)
    {
        if (s[i] >= 'a' && s[i] <= 'z')
        {
            distinct[s[i] - 'a'] = true;
        }

    }
    int count = 0;
    for (int i = 0; i < 26; i++)
    {
        if (distinct[i] == true)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}
