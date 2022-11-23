//Solution to the codeforces problem 58A-Chat room
string s = Console.ReadLine();
bool isHello = false;

int h = s.IndexOf('h');
if(h != -1)
{
    int e = s.IndexOf('e', h+1);
    if (e != -1)
    {
        int l = s.IndexOf('l', e+1);
        if(l != -1)
        {
            int l1 = s.IndexOf('l', l + 1);
            if (l1!=-1)
            {
                if(s.IndexOf('o', l1+ 1) != -1)
                {
                    isHello = true;
                }
            }
        }
    }
}
if (isHello)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
