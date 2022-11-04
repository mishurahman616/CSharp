//Solution of the codeforces problem 116A - Tram
int n = Convert.ToInt32(Console.ReadLine());
int maxPassenger = 0;
int passengerCount = 0;
int[] stationPassenger;
for(int i = 0; i < n; i++)
{
    stationPassenger = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    passengerCount -= stationPassenger[0];
    passengerCount += stationPassenger[1];
    if(passengerCount > maxPassenger)
    {
        maxPassenger = passengerCount;
    }
}
Console.WriteLine(maxPassenger);