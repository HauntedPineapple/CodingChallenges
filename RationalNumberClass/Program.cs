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
            List<RationalNumber> rNums = new List<RationalNumber>();
            rNums.Add(new RationalNumber(1, 2)); //#0
            rNums.Add(new RationalNumber(10, 8)); //#1
            rNums.Add(new RationalNumber(2, -1)); //#2
            rNums.Add(new RationalNumber(-16, -64)); //#3

            Console.WriteLine("~~~~~~~~~ Part One ~~~~~~~~~");
            for (int i = 0; i < rNums.Count; i++)
            {
                Console.WriteLine("Numerator --> " + rNums[i].Numerator + "   Denominator --> " + rNums[i].Denominator);
                Console.WriteLine(rNums[i].ToString());
            }
            Console.WriteLine();

            Console.WriteLine("~~~~~~~~~ Part Two ~~~~~~~~~");
            int number = 1;
            RationalNumber rNum_1, rNum_2, result;

            Console.WriteLine(" ~~~~~~ Addition ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(10, 8);
            result = rNum_1 + rNum_2;
            Console.WriteLine(" "+rNum_1.ToString() + " + " + rNum_2.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Multiplication ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, -1);
            result = rNum_1 * rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " * " + rNum_2.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Subtraction ~~~~~~ ");
            rNum_1 = new RationalNumber(10, 8);
            rNum_2 = new RationalNumber(-1, 4);
            result = rNum_1 - rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " - " + rNum_2.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Division ~~~~~~ ");
            rNum_1 = new RationalNumber(7, 4);
            rNum_2 = new RationalNumber(2, -1);
            result = rNum_1 - rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " - " + rNum_2.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Unary ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, -1);
            Console.WriteLine(" rNum_1 = "+rNum_1+"\t-rNum_1 = "+(-rNum_1));
            Console.WriteLine(" rNum_2 = "+rNum_2+"\t-rNum_2 = "+(-rNum_2));
            Console.WriteLine();

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


                if (denominator < 0 && numerator < 0)
                {
                    numerator *= -1;
                    denominator *= -1;
                }

                //reduce to simplest form
                int gcd = FindGCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
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
        #region Operator Overloads
        public static RationalNumber operator -(RationalNumber a)
        {
            return a * -1;
        }

        // Addition
        public static RationalNumber operator +(RationalNumber frac, int num)
        {
            frac.numerator += num * frac.denominator;
            return frac;
        }
        public static RationalNumber operator +(int num, RationalNumber frac)
        {
            frac.numerator += num * frac.denominator;
            return frac;
        }
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            a.numerator *= b.denominator;
            b.numerator *= a.denominator;
            return new RationalNumber(a.numerator + b.numerator, a.denominator * b.denominator);
        }

        // Subtraction
        public static RationalNumber operator -(RationalNumber frac, int num)
        {
            frac.numerator = frac.numerator - (num * frac.denominator);
            return frac;
        }
        public static RationalNumber operator -(int num, RationalNumber frac)
        {
            frac.numerator = (num * frac.denominator) - frac.numerator;
            return frac;
        }
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            a.numerator *= b.denominator;
            b.numerator *= a.denominator;
            return new RationalNumber(a.numerator - b.numerator, a.denominator * b.denominator);
        }

        // Multiplication
        public static RationalNumber operator *(RationalNumber frac, int num)
        {
            return new RationalNumber(1, 1);
        }
        public static RationalNumber operator *(int num, RationalNumber frac)
        {
            return new RationalNumber(1, 1);
        }
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(1, 1);
        }

        // Division
        public static RationalNumber operator /(RationalNumber frac, int num)
        {
            return new RationalNumber(1, 1);
        }
        public static RationalNumber operator /(int num, RationalNumber frac)
        {
            return new RationalNumber(1, 1);
        }
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(1, 1);
        }
        #endregion

        private int FindGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return FindGCD(b, a % b);
        }

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }
        public int Sign
        {
            get
            {
                if (numerator / denominator > 0)
                    return 1;
                if (numerator / denominator < 0)
                    return -1;
                return 0;
            }
        }
    }
}
