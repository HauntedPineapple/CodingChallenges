using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFunctions_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        static string nthFibonacci(int n)
        {
            if (n < 2)
            {
                return n.ToString();
            }
            int twoBack = 0;
            int oneBack = 1;
            int current = 0;

            for (int i = 1; i < n; i++)
            {
                current = twoBack + oneBack;
                twoBack = oneBack;
                oneBack = current;
            }

            return current.ToString();
        }
    }
}
