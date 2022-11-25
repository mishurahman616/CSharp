// Solution to the codeforces problem - 228A-Is your horseshoe on the other hoof?

HashSet<string> horsshoe = Console.ReadLine().Trim().Split().ToHashSet();
Console.WriteLine(4-horsshoe.Count);
