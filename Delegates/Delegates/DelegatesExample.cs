using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool Print(string s);
    public class DelegatesExample
    {

        //public delegate bool Print(string s);

        public void DoSomething(Action<string> f, string s) {
            f(s);
        }
        
        public bool PrintToConsole(string s)
        {
            Console.WriteLine(s);
            return true;
        }
        public bool PrintToFile(string s)
        {
            string filename = "../../../demo.txt";
            if(File.Exists(filename))
            {
                File.WriteAllText(filename, s);
            }
            else
            {
                File.Create(filename).Close();
                File.WriteAllText(filename, s);
            }
            return true;
        }
    }
}
