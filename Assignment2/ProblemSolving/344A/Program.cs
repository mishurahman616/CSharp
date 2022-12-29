//Solution to the codeforces problem - 344A-Magnets
int n = Convert.ToInt32(Console.ReadLine());
int groupCounter = 1;
string s1 = Console.ReadLine();
for(int i=1; i<n; i++)
{
    string s2= Console.ReadLine();
    if (!s1.Equals(s2))
    {
        groupCounter++;
    }
    s1 = s2;
}
Console.WriteLine(groupCounter);