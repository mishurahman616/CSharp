// Solution to the codeforces problem -479A-Expression
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());

if (a == 1 && b==1 && c==1)
{
    Console.WriteLine(3);
}
else if (a == 1)
{
    if(c == 1)
    {
        Console.WriteLine(a+b+c);
    }
    else
    {
        Console.WriteLine((a + b) * c);
    }
}
    
else if(b == 1)
{
    if(a>c)
    {
        Console.WriteLine((b+c)*a);
    }
    else
    {
        Console.WriteLine((a+b)*c);
    }
} else if (c == 1)
{
    Console.WriteLine((b+c)*a);
}
else
{
    Console.WriteLine(a*b*c);
}