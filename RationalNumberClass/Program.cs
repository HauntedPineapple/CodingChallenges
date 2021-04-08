using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rNum = new RationalNumber(1, 2);
            Console.WriteLine("Numerator --> " + rNum.Numerator + "Denominator --> " + rNum.Denominator);
            Console.WriteLine(rNum.ToString());
            int[] numerators = new int[] { 10, 2, -16 };
            int[] denominators = new int[] { 8, -1, -64 };
            for (int i = 0; i < numerators.Length; i++)
            {
                rNum = new RationalNumber(numerators[i], denominators[i]);
                Console.WriteLine("Numerator --> " + rNum.Numerator + "Denominator --> " + rNum.Denominator);
                Console.WriteLine("rNum --> "+rNum.ToString());
            }

            Console.ReadLine();
        }
    }

    struct RationalNumber
    {
        private int numerator, denominator;

        public RationalNumber(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("ERROR: Denominator cannot be zero", "den");
            }

            numerator = num;

            if (num == 0)
            {
                denominator = 1;
            }
            else
            {
                denominator = den;
            }

            if (denominator < 0 && numerator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            if (numerator % denominator == 0)
            {

            }
        }

        public override string ToString()
        {
            if (denominator == 1 || denominator == -1)
            {
                return numerator.ToString();
            }
            if (denominator < 0)
            {
                denominator *= -1;
                numerator *= -1;
            }
            return numerator + "/" + denominator;
        }

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }
    }
}
