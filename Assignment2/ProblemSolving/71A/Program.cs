// Solution to the codeforces problem - 71A-Way Too Long Words
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if (s.Length > 10)
    {
        Console.WriteLine($"{s[0]}{s.Length-2}{s[^1]}");
    }
    else
    {
        Console.WriteLine(s);
    }
}