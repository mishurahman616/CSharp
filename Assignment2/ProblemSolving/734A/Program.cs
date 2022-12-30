// Solution to the codeforces problem 734A- Anton and Danik
int n = Convert.ToInt32(Console.ReadLine());
string s = Console.ReadLine();
int A = 0;
int D = 0;
for(int i = 0; i < n; i++)
{
    if (s[i] == 'A') A++;
    else D++;
}
if (A == D) Console.WriteLine("Friendship");
else if (A > D) Console.WriteLine("Anton");
else Console.WriteLine("Danik");