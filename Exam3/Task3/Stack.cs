using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Stack
    {
        public static int Sum(this Stack<int> list)
        {
            int sum=0;
            foreach (var item in list) {
                sum += item;
            }
            return sum;
        }
    }
}
