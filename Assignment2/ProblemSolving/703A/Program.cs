// Solution to the codeforces problem - 703A-Mishka and Game
int n = Convert.ToInt32(Console.ReadLine());
int mishka = 0, chris = 0;
for(int i = 0; i < n; i++)
{
    var x = Console.ReadLine().Trim().Split().ToList().Select(x => Convert.ToInt32(x)).ToList();
    if (x[0] > x[1])
    {
        mishka++;
    }else if (x[0] < x[1])
    {
        chris++;
    }
}
if (mishka > chris)
{
    Console.WriteLine("Mishka");
}else if(chris > mishka)
{
    Console.WriteLine("Chris");
}
else
{
    Console.WriteLine("Friendship is magic!^^");
}