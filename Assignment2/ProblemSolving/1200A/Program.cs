// Solution to the codeforces problem - 1200A-Hotelier
int n = Convert.ToInt32(Console.ReadLine());
string s = Console.ReadLine();
bool[] room = new bool[10];
int l = 0;
int r = 9;
for(int i = 0; i < n; i++)
{
    if (s[i] == 'L')
    {
        for(int j=0; j<10; j++)
        {
            if (room[j] == false) {
                room[j] = true;
                break;
            }
        }
    }else if (s[i] == 'R')
    {
        for(int j=9; j>=0; j--)
        {
            if (room[j] == false)
            {
                room[j] = true;
                break;
            }
        }
    }
    else
    {
        room[s[i]-48] = false;
    }
}
for(int i = 0;i<10; i++)
{
    if (room[i] == false)
    {
        Console.Write("0");
    }
    else
    {
        Console.Write("1");
    }
}
