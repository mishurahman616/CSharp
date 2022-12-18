// Solution to the codeforces problem - 231A-Team
int n = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for(int i=0;i<n; i++)
{
    var s = Console.ReadLine().Split();
    Array.Sort(s);

    if (s[1]=="1" && s[2] == "1")
    {
        counter++;
    }

    
}

Console.WriteLine(counter);