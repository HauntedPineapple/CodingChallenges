using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStuff_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArraySummation();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }

        #region Diamond Shaped Array
        #endregion

        #region Multiplication Tables
        #endregion

        #region Array of Multiples
        #endregion

        #region Array Summation
        /// <summary>
        /// Returns "true" if any two numbers in the
        /// first array add up to any number
        /// in the second array and "false" otherwise
        /// </summary>
        static bool ArraySummation(int[] array_1, int[] array_2)
        {
            for (int i = 0; i < array_1.Length - 1; i++)
            {
                for (int k = 1; k < array_1.Length; k++)
                {
                    foreach (int number in array_2)
                    {
                        if (array_1[i] + array_1[k] == number)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        static void TestArraySummation()
        {
            int[] array_1, array_2;

            Console.WriteLine("=========== Test Case #1 ===========");
            array_1 = new int[3] { -1, 8, 3 };
            array_2 = new int[3] { 3, 7, 2 };
            Console.Write("Array_1 contains the numbers: ");
            foreach (int number in array_1)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
            Console.Write("Array_2 contains the numbers: ");
            foreach (int number in array_2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Result: " + ArraySummation(array_1, array_2).ToString());

            Console.WriteLine("=========== Test Case #2 ===========");
            array_1 = new int[3] { 9, 6, 12 };
            array_2 = new int[3] { 1, 2, 3 };
            Console.Write("Array_1 contains the numbers: ");
            foreach (int number in array_1)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.Write("Array_2 contains the numbers: ");
            foreach (int number in array_2)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Result: " + ArraySummation(array_1, array_2).ToString());
        }
        #endregion

        #region Missing Integer
        #endregion

        #region Mini Peaks
        #endregion

        #region Left Rotation
        #endregion
    }
}
