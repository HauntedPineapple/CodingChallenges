using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingDice_C_Sharp
{
    class Program
    {
        public static int[] forgottenRolls(int[] rememberedRolls, int numOfForgottenRolls, int rollMean)
        {

            return null;
        }

        static void Main(string[] args)
        {
            int[] rememberedRolls, results;
            int numOfForgottenRolls, rollMean;

            Console.WriteLine("============ Test Case 1 ============");
            rememberedRolls = new int[4] { 3, 2, 4, 3 };
            numOfForgottenRolls = 2;
            rollMean = 4; // should return {6, 6}
            Console.Write("Remembered rolls: ");
            foreach (int number in rememberedRolls)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of forgotten rolls: " + numOfForgottenRolls);
            Console.WriteLine("Average of all rolls: " + rollMean);
            Console.Write("Returns: ");
            results = forgottenRolls(rememberedRolls, numOfForgottenRolls, rollMean);
            foreach (int number in results)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("============ Test Case 2 ============");
            rememberedRolls = new int[3] { 1, 5, 6 };
            numOfForgottenRolls = 4;
            rollMean = 3; // one possible solution is {6, 1, 1, 1}
            Console.Write("Remembered rolls: ");
            foreach (int number in rememberedRolls)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of forgotten rolls: " + numOfForgottenRolls);
            Console.WriteLine("Average of all rolls: " + rollMean);
            Console.Write("Returns: ");
            results = forgottenRolls(rememberedRolls, numOfForgottenRolls, rollMean);
            foreach (int number in results)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("============ Test Case 3 ============");
            rememberedRolls = new int[4] { 1, 2, 3, 4 };
            numOfForgottenRolls = 4;
            rollMean = 6; // should return {0} because it is not possible to obtain such an average
            Console.Write("Remembered rolls: ");
            foreach (int number in rememberedRolls)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of forgotten rolls: " + numOfForgottenRolls);
            Console.WriteLine("Average of all rolls: " + rollMean);
            Console.Write("Returns: ");
            results = forgottenRolls(rememberedRolls, numOfForgottenRolls, rollMean);
            foreach (int number in results)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("============ Test Case 4 ============");
            rememberedRolls = new int[2] { 6, 1 };
            numOfForgottenRolls = 1;
            rollMean = 1; // should return {0} because it is not possible to obtain such an average
            Console.Write("Remembered rolls: ");
            foreach (int number in rememberedRolls)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of forgotten rolls: " + numOfForgottenRolls);
            Console.WriteLine("Average of all rolls: " + rollMean);
            Console.Write("Returns: ");
            results = forgottenRolls(rememberedRolls, numOfForgottenRolls, rollMean);
            foreach (int number in results)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
