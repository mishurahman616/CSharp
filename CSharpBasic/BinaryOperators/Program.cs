
sbyte x = 0b_1111000;
Console.WriteLine(x);
Console.WriteLine(Convert.ToString(x, toBase: 2));
x = (sbyte)(x >> 4);
Console.WriteLine(x);
Console.WriteLine(Convert.ToString(x, toBase:2));
x = (sbyte)(x << 4);
Console.WriteLine(x);
Console.WriteLine(Convert.ToString(x, toBase: 2));
