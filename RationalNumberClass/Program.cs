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
            rNums.Add(new RationalNumber(1, 2));
            rNums.Add(new RationalNumber(10, 8));
            rNums.Add(new RationalNumber(2, -1));
            rNums.Add(new RationalNumber(-16, -64));
            int number = 1;
            bool compare = false;
            RationalNumber rNum_1, rNum_2, result;

            #region Part One
            Console.WriteLine("~~~~~~~~~ Part One ~~~~~~~~~");
            for (int i = 0; i < rNums.Count; i++)
            {
                Console.WriteLine("Numerator --> " + rNums[i].Numerator + "   Denominator --> " + rNums[i].Denominator);
                Console.WriteLine(rNums[i].ToString());
            }
            Console.WriteLine();
            #endregion

            #region Part Two
            Console.WriteLine("~~~~~~~~~ Part Two ~~~~~~~~~");
            Console.WriteLine(" ~~~~~~ Addition ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(10, 8);
            result = rNum_1 + rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " + " + rNum_2.ToString() + " = " + result.ToString());
            rNum_1 = new RationalNumber(3, 4);
            number = 7;
            result = rNum_1 + number;
            Console.WriteLine(" " + rNum_1.ToString() + " + " + number + " = " + result.ToString());
            rNum_1 = new RationalNumber(1, 7);
            number = 5;
            result = number + rNum_1;
            Console.WriteLine(" " + number + " + " + rNum_1.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Subtraction ~~~~~~ ");
            rNum_1 = new RationalNumber(10, 8);
            rNum_2 = new RationalNumber(-1, 4);
            result = rNum_1 - rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " - " + rNum_2.ToString() + " = " + result.ToString());
            rNum_1 = new RationalNumber(3, 7);
            number = 3;
            result = rNum_1 - number;
            Console.WriteLine(" " + rNum_1.ToString() + " - " + number + " = " + result.ToString());
            rNum_1 = new RationalNumber(5, 8);
            number = 6;
            result = number - rNum_1;
            Console.WriteLine(" " + number + " - " + rNum_1.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Multiplication ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, -1);
            result = rNum_1 * rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " * " + rNum_2.ToString() + " = " + result.ToString());
            rNum_1 = new RationalNumber(5, 6);
            number = 8;
            result = rNum_1 * number;
            Console.WriteLine(" " + rNum_1.ToString() + " * " + number + " = " + result.ToString());
            rNum_1 = new RationalNumber(6, 7);
            number = 2;
            result = number * rNum_1;
            Console.WriteLine(" " + number + " * " + rNum_1.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Division ~~~~~~ ");
            rNum_1 = new RationalNumber(7, 4);
            rNum_2 = new RationalNumber(2, -1);
            result = rNum_1 / rNum_2;
            Console.WriteLine(" " + rNum_1.ToString() + " / " + rNum_2.ToString() + " = " + result.ToString());
            rNum_1 = new RationalNumber(1, 4);
            number = 3;
            result = rNum_1 / number;
            Console.WriteLine(" " + rNum_1.ToString() + " / " + number + " = " + result.ToString());
            rNum_1 = new RationalNumber(3, 8);
            number = 6;
            result = number / rNum_1;
            Console.WriteLine(" " + number + " / " + rNum_1.ToString() + " = " + result.ToString());
            Console.WriteLine();

            Console.WriteLine(" ~~~~~~ Unary ~~~~~~ ");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, -1);
            Console.WriteLine(" rNum_1 = " + rNum_1.ToString() + "\t-rNum_1 = " + (-rNum_1).ToString());
            Console.WriteLine(" rNum_2 = " + rNum_2.ToString() + "\t-rNum_2 = " + (-rNum_2).ToString());
            Console.WriteLine();
            #endregion

            #region Part Three
            Console.WriteLine("~~~~~~~~~ Part Three ~~~~~~~~~");
            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, 4);
            compare = rNum_1 == rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " == " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(2, 8);
            rNum_2 = new RationalNumber(1, 2);
            compare = rNum_1 == rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " == " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();

            rNum_1 = new RationalNumber(2, 3);
            rNum_2 = new RationalNumber(5, 6);
            compare = rNum_1 != rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " != " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(1, 4);
            rNum_2 = new RationalNumber(2, 8);
            compare = rNum_1 != rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " != " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();

            rNum_1 = new RationalNumber(3, 10);
            rNum_2 = new RationalNumber(3, 5);
            compare = rNum_1 > rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " > " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(4, 5);
            rNum_2 = new RationalNumber(2, 3);
            compare = rNum_1 > rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " > " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();

            rNum_1 = new RationalNumber(1, 2);
            rNum_2 = new RationalNumber(2, 3);
            compare = rNum_1 < rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " < " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(4, 5);
            rNum_2 = new RationalNumber(2, 8);
            compare = rNum_1 < rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " < " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();

            rNum_1 = new RationalNumber(5, 6);
            rNum_2 = new RationalNumber(1, 5);
            compare = rNum_1 >= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " >= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(1, 3);
            rNum_2 = new RationalNumber(2, 3);
            compare = rNum_1 >= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " >= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(6, 9);
            rNum_2 = new RationalNumber(2, 3);
            compare = rNum_1 >= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " >= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();

            rNum_1 = new RationalNumber(2, 5);
            rNum_2 = new RationalNumber(6, 3);
            compare = rNum_1 <= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " <= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(4, 5);
            rNum_2 = new RationalNumber(1, 10);
            compare = rNum_1 <= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " <= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            rNum_1 = new RationalNumber(6, 7);
            rNum_2 = new RationalNumber(18, 21);
            compare = rNum_1 <= rNum_2;
            Console.WriteLine(" " + rNum_1.Numerator + "/" + rNum_1.Denominator + " <= " + rNum_2.Numerator + "/" + rNum_2.Denominator + " --> " + compare.ToString());
            Console.WriteLine();
            #endregion

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
            }
        }

        public static RationalNumber Simplify(RationalNumber frac)
        {
            if (frac.denominator == 1 || frac.denominator == -1)
            {
                return frac;
            }
            if (frac.denominator < 0)
            {
                frac.denominator *= -1;
                frac.numerator *= -1;
            }
            int gcd = FindGCD(frac.numerator, frac.denominator);
            frac.numerator /= gcd;
            frac.denominator /= gcd;
            return frac;
        }
        public static int FindGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return FindGCD(b, a % b);
        }

        public override string ToString()
        {
            int gcd = FindGCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
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
        // TODO:
        //   1) Add Equals and GetHashCode overrides
        //   2) Implement implicit and explicit conversion to and from the C# decimal value type

        // Comparison
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            a = Simplify(a);
            b = Simplify(b);
            if (a.numerator == b.numerator && a.denominator == b.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            a = Simplify(a);
            b = Simplify(b);
            if (a.numerator != b.numerator || a.denominator != b.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            a = Simplify(a);
            b = Simplify(b);
            if (a.numerator * b.denominator < b.numerator * a.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            a = Simplify(a);
            b = Simplify(b);
            if (a.numerator * b.denominator > b.numerator * a.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            if (a == b)
            {
                return true;
            }
            if (a < b)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            if (a == b)
            {
                return true;
            }
            if (a > b)
            {
                return true;
            }
            return false;
        }

        // Unary
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

            return new RationalNumber(frac.numerator * num, frac.denominator);
        }
        public static RationalNumber operator *(int num, RationalNumber frac)
        {
            return new RationalNumber(num * frac.numerator, frac.denominator);
        }
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        // Division
        public static RationalNumber operator /(RationalNumber frac, int num)
        {
            if (num == 0)
            {
                throw new DivideByZeroException();
            }
            return frac * new RationalNumber(1, num);
        }
        public static RationalNumber operator /(int num, RationalNumber frac)
        {
            return num * new RationalNumber(frac.denominator, frac.numerator);
        }
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {

            return a * new RationalNumber(b.denominator, b.numerator);
        }
        #endregion

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
