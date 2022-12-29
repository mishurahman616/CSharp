// Solution to the codeforces problem-41A-Translation
string s = Console.ReadLine();
string t = Console.ReadLine();
bool flag = true;
if(s.Length == t.Length)
{
    for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
    {
        if (s[i] == t[j])
        {
            continue;
        }
        else
        {
            flag = false;
            break;
        }
    }
}
else
{
    flag = false;
}


if (flag)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}