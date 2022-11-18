// Solution to the codeforces problem 33A-Helpful Maths
var data = Console.ReadLine();
int l = data.Length;
int oneConuter = 0, twoConuter = 0, threeConuter = 0;
for(int i=0; i < l; i++)
{
    if (data[i] == '1')
    {
        oneConuter++;
    }
    else if (data[i] == '2')
    {
        twoConuter++;
    }else if (data[i] == '3')
    {
        threeConuter++;
    }
}
if (oneConuter > 0)
{
    Console.Write("1");
    oneConuter--;
}
else if(twoConuter> 0)
{
    Console.Write("2");
    twoConuter--;
}
else if(threeConuter> 0)
{
    Console.Write("3");
    threeConuter--;
}
while(oneConuter>0)
{
    Console.Write("+1");
    oneConuter--;
}
while(twoConuter> 0)
{
    Console.Write("+2");
    twoConuter--;
}
while(threeConuter> 0)
{
    Console.Write("+3");
    threeConuter--;
}