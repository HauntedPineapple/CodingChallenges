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
            TestDiamondArray();
            Console.WriteLine();
            TestMultiplicationTable();
            Console.WriteLine();
            TestMultipleArray();
            Console.WriteLine();
            TestArraySummation();
            Console.WriteLine();
            TestMissingInteger();
            Console.WriteLine();
            TestMiniPeaks();
            Console.WriteLine();
            TestRotateLeft();

            Console.ReadLine();
        }

        #region Diamond Shaped Array
        static List<int[]> DiamondArray(int size)
        {
            List<int[]> output = new List<int[]>();
            return output;
        }
        static void TestDiamondArray()
        {
            Console.WriteLine("=============== Diamond Shaped Array ===============");
            for (int a = 1; a < 6; a++)
            {
                Console.WriteLine("------------ DiamondArray(" + a + ") ------------");
                List<int[]> result = DiamondArray(a);
                int count = 0;
                for (int i = 0; i < result.Count; i++)
                {
                    Console.Write("[");
                    for (int k = 0; k < result[i].Length; k++)
                    {
                        count++;
                        if (count < result[i].Length)
                        {
                            Console.Write(result[i][k] + ", ");
                        }
                        else
                        {
                            Console.Write(result[i][k]);
                        }
                    }
                    count = 0;
                    Console.Write("]");
                    Console.WriteLine();
                }
            }
        }
        #endregion

        #region Multiplication Tables
        static int[,] MultiplicationTable(int size)
        {
            int[,] output = new int[size, size];
            return output;
        }
        static void TestMultiplicationTable()
        {
            Console.WriteLine("=============== Multiplication Tables ===============");
            for (int a = 1; a < 6; a++)
            {
                Console.WriteLine(a + " x " + a + " " + "Multiplication Table");
                int[,] result = MultiplicationTable(a);
                int count = 0;
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int k = 0; k < result.GetLength(1); k++)
                    {
                        count++;
                        if (count < result.GetLength(1))
                        {
                            Console.Write(result[i, k] + ", ");
                        }
                        else
                        {
                            Console.Write(result[i, k]);
                        }
                    }
                    count = 0;
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Array of Multiples
        static int[] MultipleArray(int num, int length)
        {
            int[] output = new int[length];
            return output;
        }
        static void TestMultipleArray()
        {
            Console.WriteLine("=============== Array of Multiples ===============");
            int[] nums = new int[] { 7, 12, 17 };
            int[] lengths = new int[] { 5, 10, 6 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("MultipleArray(" + nums[i] + ", " + lengths[i] + ") --> ");
                Console.Write("[");
                int count = 0;
                int[] output = MultipleArray(nums[i], lengths[i]);
                for (int a = 0; a < output.Length; a++)
                {
                    count++;
                    if (count < output.Length)
                    {
                        Console.Write(output[a] + ", ");
                    }
                    else
                    {
                        Console.Write(output[a]);
                    }
                }
                Console.WriteLine("]");
            }
        }
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
            Console.WriteLine("=============== Array Summation ===============");
            Console.WriteLine("~~~~~~~~~~~~ Test Case #1 ~~~~~~~~~~~~");
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

            Console.WriteLine("~~~~~~~~~~~~ Test Case #2 ~~~~~~~~~~~~");
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
        static int MissingInteger(int[] arr)
        {
            return -1;
        }
        static void TestMissingInteger()
        {
            Console.WriteLine("=============== Missing Integer ===============");
            List<int[]> testArrays = new List<int[]> { new int[]{ 1, 3, 6, 4, 1, 2},
                                                       new int[]{ 1, 2, 3},
                                                       new int[]{ -1, -3} };
            foreach (int[] array in testArrays)
            {
                Console.Write("[");
                int count = 0;
                for (int a = 0; a < array.Length; a++)
                {
                    count++;
                    if (count < array.Length)
                    {
                        Console.Write(array[a] + ", ");
                    }
                    else
                    {
                        Console.Write(array[a]);
                    }
                }
                Console.WriteLine("] --> " + MissingInteger(array));
            }
        }
        #endregion

        #region Mini Peaks
        static List<int> MiniPeaks(int[] arr)
        {
            List<int> output = new List<int>();
            return output;
        }
        static void TestMiniPeaks()
        {
            Console.WriteLine("=============== Mini Peaks ===============");
            List<int[]> testArrays = new List<int[]> { new int[]{4, 5, 2, 1, 4, 9, 7, 2},
                                                       new int[]{ 1, 2, 1, 1, 3, 2, 5, 4, 4},
                                                       new int[]{ 1, 2, 3, 4, 5, 6 } };
            int count = 0;
            foreach (int[] array in testArrays)
            {
                Console.Write("[");
                count = 0;
                for (int a = 0; a < array.Length; a++)
                {
                    count++;
                    if (count < array.Length)
                    {
                        Console.Write(array[a] + ", ");
                    }
                    else
                    {
                        Console.Write(array[a]);
                    }
                }
                Console.Write("] --> ");
                Console.Write("[");
                List<int> output = MiniPeaks(array);
                for (int i = 0;i < output.Count; i++)
                {
                    count++;
                    if (count < output.Count)
                    {
                        Console.Write(output[i] + ", ");
                    }
                    else
                    {
                        Console.Write(output[i]);
                    }
                }
                Console.WriteLine("]");
            }
        }
        #endregion

        #region Left Rotation
        static int[] RotateLeft(int[] arr, int r)
        {
            return null;
        }
        static void TestRotateLeft()
        {
            Console.WriteLine("=============== Left Rotation ===============");

        }
        #endregion
    }
}
