//Solution to the codeforces problem 271A- Beautiful Year
var data = Console.ReadLine();
int onePlace = data[3] - '0';
int tenPlace = data[2] - '0';
int hundredPlace = data[1] - '0';
int thousandPlace = data[0] - '0';

while (true)
{

    if (onePlace == 9)
    {
        onePlace= 0;
        tenPlace++;
    }
    else
    {
        onePlace++;
    }
    if(tenPlace>9)
    {
        tenPlace= 0;
        hundredPlace++;
    } 
    if(hundredPlace> 9)
    {
        hundredPlace= 0;
        thousandPlace+= 1;
    }
    if(onePlace != tenPlace && onePlace != hundredPlace && onePlace != thousandPlace && tenPlace != hundredPlace && tenPlace != thousandPlace && hundredPlace != thousandPlace)
    {
        break;
    }
}
Console.WriteLine($"{thousandPlace}{hundredPlace}{tenPlace}{onePlace}");
