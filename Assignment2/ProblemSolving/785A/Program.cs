//Solution to the codeforces problem - 785A-Anton and Polyhedrons

int n = Convert.ToInt32(Console.ReadLine().Trim());
int sum = 0;
for (int i=0; i<n; i++)
{
    string s = Console.ReadLine();
  
    switch (s)
    {
        case "Tetrahedron":
            sum += 4;
            break;
        case "Cube":
            sum += 6;
            break;
        case "Octahedron":
            sum += 8;
            break;
        case "Dodecahedron":
            sum += 12;
            break;
        case "Icosahedron":
            sum += 20;
            break;

    }
    
}
Console.WriteLine(sum);