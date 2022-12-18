// Solution to the codeforces problem - 1207A-There Are Two Types Of Burgers
int n = Convert.ToInt32(Console.ReadLine()); 
for(int i=0; i<n; i++)
{
    var data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var prices = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int buns = data[0] / 2;
    int sum1=0, sum2=0;
    int cb = 0, hb = 0;
    if (data[0]<=0)
    {
        Console.WriteLine(0);
    }
    else
    {
        if (prices[0] > prices[1])
        {
            cb = Math.Min(buns, data[1]);
            buns = buns - cb;
            sum1 = cb * prices[0];
            hb = Math.Min(buns, data[2]);
            sum2 = hb * prices[1];
        }
        else
        {
            hb = Math.Min(buns, data[2]);
            buns = buns - hb;
            sum1 = hb * prices[1];
            cb = Math.Min(buns, data[1]);
            sum2 = cb * prices[0];
        }
        Console.WriteLine(sum1 + sum2);

    }

}