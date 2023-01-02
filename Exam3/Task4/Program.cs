
var path = "../../../demo.txt"; 
FileInfo f = new FileInfo(path);
using FileStream stream = f.Open(FileMode.Open);

for (int i = 0; i < f.Length; i++)
{
    int c = stream.ReadByte();
    Console.WriteLine(((char)c));
}