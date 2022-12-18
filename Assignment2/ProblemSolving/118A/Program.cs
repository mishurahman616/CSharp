// Solution to the codeforces problem - 118A-String Task
string s = Console.ReadLine().ToLower();
foreach(var c in s)
{
    if (c == 'a' || c=='o' ||c=='e' || c=='y' || c=='u' || c == 'i')
    {
        continue;
    }
    else
    {
        Console.Write("."+c);
    }

}