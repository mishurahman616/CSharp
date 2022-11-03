using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class A996
    {
        ////Solution of the codeforces problem 996A - Hit the Lottery
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int bill = 0;
            bill += n / 100;
            n%=100;
            bill += n / 20;
            n%=20;
            bill += n / 10;
            n%=10;
            bill += n / 5;
            n%=5;
            bill += n;

            Console.WriteLine(bill);
        }

    }

}
