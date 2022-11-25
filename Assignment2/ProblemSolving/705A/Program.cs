// Solution to the codeforces problem - 705A-Hulk
int n = Convert.ToInt32(Console.ReadLine());
bool love = true;
Console.Write("I hate ");
for (int i = 2; i <= n; i++)
{
    if (love)
    {
        Console.Write("that I love ");
        love= false;
    }
    else
    {
        Console.Write("that I hate ");
        love= true;
    }
   
}
Console.Write("it");