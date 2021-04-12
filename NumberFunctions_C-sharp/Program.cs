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

        static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num-1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] interprimeNumbers(int num)
        {
            if (isPrime(num))
            { // a prime number cannot be interprime
                return new int[0];
            }

            return new int[0];
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
