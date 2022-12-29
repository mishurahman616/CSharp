// Solution to the codeforces problem-43A-Football
int n = Convert.ToInt32(Console.ReadLine());
int t1Counter=0, t2Counter=0;
string team1, team2="";
team1= Console.ReadLine();
t1Counter++;
for(int i = 1; i < n; i++)
{
   string team = Console.ReadLine();
    if(team1 == team)
    {
        t1Counter++;
    }
    else
    {
        t2Counter++;
        team2 = team;
    }

}

if(t1Counter > t2Counter)
{
    Console.WriteLine(team1);
}
else
{
    Console.WriteLine(team2);
}