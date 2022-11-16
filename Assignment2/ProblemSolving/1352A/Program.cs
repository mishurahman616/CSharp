// Solution to the codeforces problem 1352A - Sum of Round Numbers
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    string roundedNumber = null;

        for(int j = 0, multiPlier=10; j <= 4; j++, multiPlier *= 10)
        {
           int digit= n % 10;
            n = n / 10;
            if(digit != 0)
            {
                roundedNumber += (digit * multiPlier / 10)+" ";
                counter++;
            }
        }      
    Console.WriteLine(counter);
    Console.WriteLine(roundedNumber);
}