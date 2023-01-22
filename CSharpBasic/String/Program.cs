
string borzeCode = Console.ReadLine();
int length = borzeCode.Length;

for(int i=0; i<length; i++)
{
    if(borzeCode[i] == '-')
    {
        if (borzeCode[i+1] == '-')
        {
            Console.Write(2);
            i++;
        }
        else if(borzeCode[i+1] == '.')
        {
            Console.Write(1);
            i++;
        }
    }
    else
    {
        Console.Write(0);

    }
}
