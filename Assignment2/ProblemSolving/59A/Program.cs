//Solution to the codeforces problem 469A-Word
string s = Console.ReadLine();
int counter = 0;
for(int i=0; i<s.Length; i++)
{
    if (s[i]>='a' && s[i] <= 'z')
    {
        counter++;
    }
}

if(counter >= Math.Ceiling(s.Length / 2.0))
{
    Console.WriteLine(s.ToLower());
}
else
{
    Console.WriteLine(s.ToUpper());
}