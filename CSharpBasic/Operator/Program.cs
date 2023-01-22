uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
int x = 3;
Console.WriteLine("\n" + Convert.ToString(x, toBase: 8));

Console.WriteLine($"\nBefore: {Convert.ToString(m, toBase: 2)}");

uint y = m << 4;
Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");