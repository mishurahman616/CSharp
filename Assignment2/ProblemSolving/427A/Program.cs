// Solution to the codeforces problem 427A-Police Recruits
int n = Convert.ToInt32(Console.ReadLine());
var data = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

uint freePolice = 0;
int unTreated = 0;
foreach(var item in data)
{
    if (item == -1)
    {
        if (freePolice == 0)
        {
            unTreated++;
        }
        else
        {
            freePolice--;
        }
    }
    else
    {
        freePolice += (uint) item;
    }
}

Console.WriteLine(unTreated);