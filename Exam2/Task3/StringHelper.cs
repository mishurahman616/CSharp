using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class StringHelper
    {
        public string Append(params string[] list)
        {
            string concated = "";
            for(int i=0; i<list.Length; i++)
            {
                concated += list[i];
            }
            return concated;
        }
    }
}
