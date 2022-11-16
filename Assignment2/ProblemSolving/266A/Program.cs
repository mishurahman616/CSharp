// Solution to the codeforces problem 266A-Stones on the Table
int n = Convert.ToInt32(Console.ReadLine());
string s = Console.ReadLine();
int counter = 0;
for(int i = 1; i < n; i++)
{
    if (s[i] == s[i - 1])
    {
        counter++;
    }
}
Console.WriteLine(counter);