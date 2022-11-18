//Solution to the codeforces problem 469A-I Wanna Be the Guy
int n = Convert.ToInt32(Console.ReadLine());
var X = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
var Y = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int counter = X[0];
bool[] solved = new bool[n+1];
for(int i=1; i <= X[0]; i++)
{
    solved[X[i]] = true;
}

for(int i=1; i <= Y[0]; i++)
{
    if (solved[Y[i]] == false)
    {
        counter++;
    }
}

if(counter == n)
{
    Console.WriteLine("I become the guy.");
}
else
{
    Console.WriteLine("Oh, my keyboard!");
}
