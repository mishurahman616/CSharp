//Solution of the codeforces problem 112A - Petya and Strings

    string s = Console.ReadLine();
    string s1 = Console.ReadLine();
    int comparedValue = 0;
    int l1 = s.Length;
    int l2 = s1.Length;
    int l;
    if (l1 < l2)
    {
        l = l1;
    }
    else
    {
        l = l2;
    }
    for (int i = 0; i < l; i++)
    {
        if (char.ToLower(s[i]) == char.ToLower(s1[i]))
        {
            comparedValue = 0;
        }
        else if (char.ToLower(s[i]) > char.ToLower(s1[i]))
        {
            comparedValue = 1;
            break;
        }
        else
        {
            comparedValue = -1;
            break;
        }
    }
    if (comparedValue == 0 && (l1 > l2))
    {
        Console.WriteLine(1);
    }
    else if (comparedValue == 0 && (l2 > l1))
    {
        Console.WriteLine(-1);
    }
    else
    {
        Console.WriteLine(comparedValue);
    }

