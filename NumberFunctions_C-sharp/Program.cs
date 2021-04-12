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
            Console.WriteLine("----- Is It Prime? -----");
            Console.WriteLine("The first 50 prime numbers are: ");
            int count = 0;
            int number = 0;
            while (count < 50)
            {
                if (isPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
            Console.WriteLine();

            Console.WriteLine("----- Interprime Numbers -----");
            int[] testNums = new int[3] { 6, 9, 8 };
            foreach (int num in testNums)
            {
                int[] output = interprime(num);
                Console.Write("interprime(" + num + ") --> [");
                for (int i = 0; i < output.Length; i++)
                {
                    if (i < output.Length - 1)
                    {
                        Console.Write(output[i]+", ");
                    }
                    else
                    {
                        Console.Write(output[i]);
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }

            Console.WriteLine("----- Nth Fibonacci -----");
            for (int i = 10; i < 60; i += 10)
            {
                Console.WriteLine(i + "th Fibonacci: " + nthFibonacci(i));
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        static bool isPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int[] interprime(int num)
        {
            if (isPrime(num))
            { // a prime number cannot be interprime
                return new int[0] { };
            }
            int leftPrime = num - 1;
            int rightPrime = num + 1;
            while (!isPrime(leftPrime))
            {
                leftPrime--;
            }
            while (!isPrime(rightPrime))
            {
                rightPrime++;
            }
            return new int[2] { leftPrime, rightPrime };
        }

        static string nthFibonacci(int n)
        {
            if (n < 2)
            {
                return n.ToString();
            }
            //int twoBack = 0;
            //int oneBack = 1;
            //int current = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    current = twoBack + oneBack;
            //    twoBack = oneBack;
            //    oneBack = current;
            //}

            // Fn = {[(√5 + 1)/2] ^ n} / √5 
            double temp = (1 + Math.Sqrt(5)) / 2;
            int fibNum = (int)Math.Round(Math.Pow(temp, n) / Math.Sqrt(5));
            return fibNum.ToString();
        }


    }
}
