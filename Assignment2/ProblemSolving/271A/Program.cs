//Solution to the codeforces problem 271A- Beautiful Year
var data = Console.ReadLine();
int onePlace = data[3] - '0';
int tenPlace = data[2] - '0';
int hundredPlace = data[1] - '0';
int thousandPlace = data[0] - '0';
bool change = false;
while (true)
{

    if (onePlace == 9)
    {
        onePlace= 0;
        if (tenPlace == 9) 
        { 
            change = true; 
        }
        else 
        {
            tenPlace++;
            change = false;
        }

    }
    else
    {
        onePlace++;
    }
    if(tenPlace== 9 && change)
    {
        tenPlace= 0;
        if(hundredPlace== 9) 
        { 
            change = true;
        }
        else
        {
            hundredPlace++;
            change = false;
        }
    } 
    if(hundredPlace== 9 && change)
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
