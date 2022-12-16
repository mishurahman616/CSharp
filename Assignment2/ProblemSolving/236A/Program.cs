// Solution to the codeforces problem - 236A-Boy or Girl

string s = Console.ReadLine();
bool[] letters = new bool[26];
int distinct = 0;
for(int i=0; i<s.Length; i++)
{
    letters[s[i] - 97] = true;
}
for(int i=0; i<letters.Length; i++)
{
    if (letters[i])
    {
        distinct++;
    }
}
if (distinct %2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}