//Solution to the codefoces problem 1623A-Robot Cleaner
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    var data = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
    int timer = 0;
    int robotX = data[2], robotY = data[3], dirtyX = data[4], dirtyY = data[5];
    int xIncrement = 1, yIncrement = 1;
    while(!(robotX==dirtyX || robotY == dirtyY))
    {
        if (robotX == data[0] && robotY == data[1])
        {
            xIncrement = -1; yIncrement = -1;
        }else if (robotX == data[0])
        {
            xIncrement = -1;
        }else if (robotY == data[1])
        {
            yIncrement = -1;
        }
        robotX += xIncrement;
        robotY += yIncrement;
        timer++;
    }
    Console.WriteLine(timer);
}