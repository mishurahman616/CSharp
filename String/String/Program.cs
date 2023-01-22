//input:
//test case, n
//grid Lenth, t;
// string grid row, 

//task:
//character can be sort within same row
// check coumns are in asndeing order or not

//output:
//Yes/No

int n = Convert.ToInt32(Console.ReadLine().Trim());
List<string> listans = new List<string>();
for(int i=0; i<n; i++)
{
    int t = Convert.ToInt32(Console.ReadLine().Trim());
    List<string> grid = new List<string>();
    for (int j=0; j<t; j++)
    {
        grid.Add(Console.ReadLine());
    }
    
    bool ascendingCol = true;
    grid[0] = string.Concat(grid[0].OrderBy(ch => ch));
    for (int r=1; r<grid.Count; r++)
    {
        grid[r] = string.Concat(grid[r].OrderBy(ch=>ch));
        for (int c=0; c < grid[0].Length; c++)
        {
            if (grid[r][c].CompareTo(grid[r-1][c]) <0)
            {
                ascendingCol = false;
                break;
            }
        }
        if(!ascendingCol)
        {
            break;
        }
    }


    if (ascendingCol)
    {
        Console.WriteLine("YES");
        listans.Add("YES");
    }
    else
    {
        Console.WriteLine("NO");
        listans.Add("NO");
    }
}

Console.WriteLine(String.Join("\n", listans));