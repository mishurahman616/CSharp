// Solution of the codeforces problem 1335A - Candies and Two Sisters
int t = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(n%2==0?n/2-1:n/2);
}