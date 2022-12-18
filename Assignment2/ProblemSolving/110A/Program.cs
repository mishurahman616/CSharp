// Solution to the codeforces problem - 110A-Nearly Lucky Number
string s = Console.ReadLine();

int i = 0, l = s.Length - 1;
int counter = 0;
while (i < l)
{
    if (s[i]=='4' || s[i] == '7')
    {
        counter++;
    }
    if ( s[l] == '4' || s[l] == '7')
    {
        counter++;
    }
    i++;
    l--;
}
if(i==l && (s[i]=='4' || s[i] == '7'))
{
    counter++;
}
if (counter==4 || counter == 7)
{
    Console.WriteLine("YES");
}else
{
    Console.WriteLine("NO");
}