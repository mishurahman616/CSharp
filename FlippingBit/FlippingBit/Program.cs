
// Flipping bit
long a = 2147483647;
int a2 = (int)a;
string s = Convert.ToString(~a2, toBase:2);
Console.WriteLine(s);
Console.WriteLine(Convert.ToUInt32(s, 2));

//String to char access
string s2 = "abCd";
Console.WriteLine(Char.ToLower(s2[2]) - 'a');

//others
int k = 100;
int k1 = 200;
List<int> l = new List<int>();
    Console.WriteLine(k.CompareTo(k1));
string s3 = null;
s3 ??= "hello";
string s4 = "h";
s4 ??= "hi";
object obj = new{ x = 5, y = 6 };
(int x, int y) tuple = (5, 6);
tuple.x = 200;
Console.WriteLine(tuple.x);
var anonymous = new {a=5, b=7 };

