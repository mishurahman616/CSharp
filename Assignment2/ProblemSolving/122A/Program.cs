// Solution to the codeforces problem - 122A-Lucky Division

string s = Console.ReadLine();
int n = Convert.ToInt32(s);
bool lucky=true;
 for(int i=0; i<s.Length; i++)
{
    if (!(s[i]=='4' || s[i]=='7'))
    {
        lucky= false;
        break;
    }
}
if (lucky)
{
    Console.WriteLine("YES");
}
else
{
    if (n % 4 == 0 || n % 7 == 0 || n % 47 == 0 || n % 74 == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
