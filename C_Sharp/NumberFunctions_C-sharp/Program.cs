﻿using System;
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
            int[] input;

            #region Prime
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
            #endregion

            #region Interprime
            Console.WriteLine("----- Interprime Numbers -----");
            input = new int[4] { 6, 9, 13, 44 };
            foreach (int num in input)
            {
                int[] output = interprime(num);
                Console.Write("interprime(" + num + ") --> [");
                for (int i = 0; i < output.Length; i++)
                {
                    if (i < output.Length - 1)
                    {
                        Console.Write(output[i] + ", ");
                    }
                    else
                    {
                        Console.Write(output[i]);
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
            #endregion

            #region Exapnded Form
            Console.WriteLine("----- Expanded Numbers -----");
            input = new int[5] { 25, 70701, 685, 1037903, 802539 };
            foreach (int num in input)
            {
                Console.WriteLine(num + " --> " + expandedForm(num));
            }
            #endregion

            #region Moran Numbers
            Console.WriteLine("----- Moran Numbers -----");
            input = new int[3] { 132, 133, 134 };
            foreach (int num in input)
            {
                if (moranOrHarshad(num) == "Neither")
                {
                    Console.WriteLine(num + " is neither a Moran nor a Harshad number");
                }
                if (moranOrHarshad(num) == "M")
                {
                    Console.WriteLine(num + " is a Moran number");
                }
                if (moranOrHarshad(num) == "H")
                {
                    Console.WriteLine(num + " is a Harshad number");
                }
            }
            #endregion

            #region Fibonacci
            Console.WriteLine("----- Nth Fibonacci -----");
            for (int i = 5; i <= 50; i+=5)
            {
                Console.WriteLine(i + "th Fibonacci: " + nthFibonacci(i));
            }
            #endregion

            #region Perfect Numbers
            Console.WriteLine("----- Perfect Numbers -----");
            input = new int[3] { 6, 11, 28 };
            foreach (int num in input)
            {
                if (isPerfect(num))
                {
                    Console.WriteLine(num + " IS a perfect number");
                }
                else
                {
                    Console.WriteLine(num + " is NOT a perfect number");
                }
            }
            #endregion

            #region Palindromic Numbers
            Console.WriteLine("----- Palindromic Numbers -----");
            input = new int[5] { 123, 36863, 73167, 22996622, 27872 };
            foreach (int num in input)
            {
                if (isPalindrome(num))
                {
                    Console.WriteLine(num + " IS a palindrome");
                }
                else
                {
                    Console.WriteLine(num + " is NOT a palindrome");
                }
            }
            #endregion

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
                return new int[0];
            }
            int leftPrime = num;
            int leftCount = 0;
            int rightPrime = num;
            int rightCount = 0;
            while (!isPrime(leftPrime))
            {
                leftCount++;
                leftPrime--;
            }
            while (!isPrime(rightPrime))
            {
                rightCount++;
                rightPrime++;
            }
            if (rightCount != leftCount)
            {
                return new int[0];
            }
            return new int[2] { leftPrime, rightPrime };
        }

        static string expandedForm(int number)
        {
            string result = "";
            string num = number.ToString();
            int numZeros = num.Length - 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '0')
                {
                    result += num[i];
                    if (i < num.Length - 1) //until we get to the 1s digit
                    {
                        for (int j = 0; j < numZeros; j++)
                        {
                            result += "0";
                        }
                        result += " + ";
                    }
                }
                numZeros--;
            }

            return result;
        }

        /// <returns>"M" if the number is a Moran number,
        /// "H" if the number is a Harshad number or "Neither" if it is neither
        /// </returns>
        static string moranOrHarshad(int num)
        {
            int sum = 0;
            int number = num;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (number % sum == 0)
            {
                if (isPrime(number / sum))
                {
                    return "M";
                }
                return "H";
            }
            return "Neither";
        }

        /// <summary>
        /// Works up to the 92nd Fibonacci
        /// </summary>
        static string nthFibonacci(int n)
        {
            if (n < 2)
            {
                return n.ToString();
            }

            // Fn = {[(√5 + 1)/2] ^ n} / √5 
            double temp = (1 + Math.Sqrt(5)) / 2;
            long fibNum = (long)Math.Round(Math.Pow(temp, n) / Math.Sqrt(5));
            return fibNum.ToString();
        }

        static bool isPerfect(int num)
        {
            return false;
        }

        static bool isPalindrome(int num)
        {
            string number = num.ToString();
            int j = number.Length - 1;
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[j])
                {
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}
