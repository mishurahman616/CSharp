// Solution to the codeforces problem - 513A - Elephant
int n = Convert.ToInt32(Console.ReadLine());

if (n % 5 == 0)
{
    Console.WriteLine(n / 5);
}
else
{
    Console.WriteLine((n / 5)+1);
}