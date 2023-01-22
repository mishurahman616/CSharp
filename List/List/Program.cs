
using System.Collections.Immutable;

List<List<int>> list = new List<List<int>>();

List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
for(int i=0; i<4; i++)
{
    list.Add(new List<int>());
}
foreach(int item in list2)
{
    if (item % 2 != 0)
    {
        list[0].Add(item);
    }
    else
    {
        list[1].Add(item);
    }
}
Console.WriteLine(list[0].Count);
foreach(var item in list)
{
    foreach(var i in item)
    {
        Console.WriteLine(i);
    }
}

