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
            testArraySummation();
        }

        /// <summary>
        /// Returns "true" if any two numbers in the
        /// first array add up to any number
        /// in the second array and "false" otherwise
        /// </summary>
        static bool arraySummation(int[] array_1, int[] array_2)
        {
            return false;
        }

        static void testArraySummation()
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
            Console.WriteLine("");
            Console.WriteLine("Result: " + arraySummation(array_1, array_2).ToString());

            Console.WriteLine("=========== Test Case #2 ===========");
            array_1 = new int[3] { 9, 6, 12 };
            array_2 = new int[3] { 1, 2, 3 };
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
            Console.WriteLine("");
            Console.WriteLine("Result: " + arraySummation(array_1, array_2).ToString());
        }

    }
}
