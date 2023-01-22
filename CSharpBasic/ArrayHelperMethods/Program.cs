string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("Array elements are: ");
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
Console.WriteLine("\nSorted....");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Array.Reverse(pallets);
Console.WriteLine("\nReversed");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
Array.Clear(pallets, 0, 1);
Console.WriteLine("Cleared one value from index 0");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Array resized");
Array.Resize(ref pallets, 6);
Console.WriteLine(pallets.Length);


//string printing each word in reverse but in the same position

string pangram = "The quick brown fox jumps over the lazy dog";
Console.Write("\n\nOriginal string: ");
Console.WriteLine(pangram);
string[] words = pangram.Split(' ');
Console.Write("Reversed string: ");
foreach (string word in words)
{
    char[] charWords = word.ToCharArray();
    Array.Reverse(charWords);
    string pangram2 = String.Concat(charWords) + " "; 
    Console.Write(pangram2);
}




