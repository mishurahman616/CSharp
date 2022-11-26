// Solution to the codeforces problem 141A-Amusing Joke
string gest = Console.ReadLine();
string host = Console.ReadLine();
string pile = Console.ReadLine();

if ((gest + host).Length == pile.Length)
{
    char[] pileArr = pile.ToCharArray();
    Array.Sort(pileArr);
    char[] gh = (gest + host).ToCharArray();
    Array.Sort(gh);
    bool isEqual = true;
    for(int i=0; i<gh.Count(); i++)
    {
        if (gh[i] != pileArr[i])
        {
            isEqual=false;
            break;
        }
    }
    if(isEqual)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("NO");
}
