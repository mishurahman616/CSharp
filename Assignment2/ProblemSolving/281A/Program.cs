// Solution to the codeforces problem - 281A-Word Capitalization
using System.Text;

string s=Console.ReadLine();

StringBuilder stringBuilder=new StringBuilder(s);
stringBuilder[0] = char.ToUpper(s[0]);
Console.WriteLine(stringBuilder);