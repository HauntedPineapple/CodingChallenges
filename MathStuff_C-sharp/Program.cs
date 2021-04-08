using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStuff_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestLinearSolver();
            //Console.WriteLine();

            TestQuadraticRootFinder();
            Console.WriteLine();

            TestQuadraticSolver();
            Console.WriteLine();

            TestQuadraticVertex();
            Console.WriteLine();

            TestQuadraticRootSum();
            Console.WriteLine();

            //TestQuarticSolver();
            //Console.WriteLine();

            //TestIntegral();
            //Console.WriteLine();

            //TestMaxDistance();
            //Console.WriteLine();

            TestClockAngle();

            Console.ReadLine();
        }

        #region Solve a Linear Equation
        /// <param name="equation">a string that represents a linear equation with one unknown, "x"</param>
        static string LinearEquationSolver(string equation)
        {
            return "";
        }
        static void TestLinearSolver()
        {
            Console.WriteLine("============ Solve a Linear Equation ============");
            string[] input = new string[] { "4x-7=x+11", "3x=2x+x", "3x=3x+2" };
            foreach (string equation in input)
            {
                Console.WriteLine(equation + " -> " + LinearEquationSolver(equation));
            }
        }
        #endregion

        #region Quadratic Equation
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>Root value of the equation ax^2 + bx + c</returns>
        static string FindQuadraticRoot(int a, int b, int c)
        {
            double root;
            // If the discriminant, b2−4ac, is negative, 
            //there are two complex solutions so return "Null"
            if (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) < 0)
            {
                return "NULL";
            }

            // Quadratic equation: (-b+√(b^2-4ac))/2a
            root = -b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            root = root / (2 * a);
            root = (int)root;
            return root.ToString();
        }
        static void TestQuadraticRootFinder()
        {
            Console.WriteLine("============ Quadratic Equation ============");
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");
            int[] a = new int[] { 1, 2, 1 };
            int[] b = new int[] { -12, -7, 2 };
            int[] c = new int[] { -28, 3, -3 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("The quadratic equation with coefficients a = " + a[i] + " b = " + b[i] + " c = " + c[i]);
                Console.WriteLine("has the root: x = " + FindQuadraticRoot(a[i], b[i], c[i]));
            }
        }
        #endregion

        #region How Many Solutions Does This Quadratic Have?
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>The number of solutions to the equation ax^2 + bx + c</returns>
        static int FindNumOfQuadraticSolutions(int a, int b, int c)
        {
            double discriminant = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if (discriminant > 0)
            {
                return 2;
            }
            if (discriminant == 0)
            {
                return 1;
            }
            if (discriminant < 0)
            {
                return 0;
            }
            return 0;
        }
        static void TestQuadraticSolver()
        {
            Console.WriteLine("============ How Many Solutions Does This Quadratic Have? ============");
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");
            int[] a = new int[] { 1, 1, 1 };
            int[] b = new int[] { 0, 0, 0 };
            int[] c = new int[] { -1, 0, 1 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("The quadratic equation with coefficients a = " + a[i] + " b = " + b[i] + " c = " + c[i]);
                Console.WriteLine("Has " + FindNumOfQuadraticSolutions(a[i], b[i], c[i]) + " solution(s).");
            }
        }
        #endregion

        #region Vertex of a Quadratic
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>The vertex of the quadratic curve represented by the equation ax^2 + bx + c
        /// with the first number in the array being the x-value and the second value being the y-value</returns>
        static double[] FindQuadraticVertex(int a, int b, int c)
        {
            /// A quadratic equation can be expressed two ways:
            /// Standard form: f(x)=ax^2+bx+c
            /// Vertex form: f(x)=a(x+h)^2+k
            /// Where (-h, k) is the vertex
            double h = 0;
            double k = 0;

            h = b / 2 * a;
            k = c - (Math.Pow(b, 2) / 4 * a);

            return new double[] { -h, k };
        }
        static void TestQuadraticVertex()
        {
            Console.WriteLine("============ Vertex of a Quadratic ============");
            int[] a = new int[] { 1, -1, 1 };
            int[] b = new int[] { 0, 0, 10 };
            int[] c = new int[] { 25, 25, 4 };
            double[] solution;
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");
            for (int i = 0; i < a.Length; i++)
            {
                solution = FindQuadraticVertex(a[i], b[i], c[i]);
                Console.WriteLine("The quadratic equation with coefficients a = " + a[i] + " b = " + b[i] + " c = " + c[i]);
                Console.WriteLine("has a vertex at (" + solution[0] + ", " + solution[1] + ")");
            }
        }
        #endregion

        #region Sum of Quadratic Roots
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        static double SumOfQuadraticRoots(int a, int b, int c)
        {
            /*Round answer to two decimal places.
	        If there is only one real root return 1.
        	If there are no real roots, return 0.*/

            if (FindNumOfQuadraticSolutions(a, b, c) > 0)
            {
                double root_1, root_2;
                root_1 = -b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                root_1 = root_1 / (2 * a);
                root_2 = -b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
                root_2 = root_2 / (2 * a);
                return Math.Round(root_1 + root_2, 2);
            }
            if (FindNumOfQuadraticSolutions(a, b, c) == 0)
            {
                return 1;
            }
            if (FindNumOfQuadraticSolutions(a, b, c) < 0)
            {
                return 0;
            }

            return -1;
        }
        static void TestQuadraticRootSum()
        {
            Console.WriteLine("============ Sum of Quadratic Roots ============");
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");
            int[] a = new int[] { 2, 3, 4 };
            int[] b = new int[] { 4, 4, 3 };
            int[] c = new int[] { -6, -3, 8 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("The sum of the roots of the quadratic equation with coefficients a = " + a[i] + " b = " + b[i] + " c = " + c[i]);
                Console.WriteLine("is " + SumOfQuadraticRoots(a[i], b[i], c[i]));
            }
        }
        #endregion

        #region Quartic Equation
        /// <param name="a">coefficient of x^4</param>
        /// <param name="b">coefficient of x^2</param>
        /// <param name="c">constant term</param>
        /// <returns></returns>
        static int FindNumOfQuarticSolutions(int a, int b, int c)
        {
            return 0;
        }
        static void TestQuarticSolver()
        {
            Console.WriteLine("============ Quartic Equation ============");
            Console.WriteLine("A quartic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^4");
            Console.WriteLine("\"b\" is the coefficient of x^2");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^4 + bx^2 +c");
            int[] a = new int[] { 1, 4, 1 };
            int[] b = new int[] { -5, 3, 10 };
            int[] c = new int[] { 4, -1, 9 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("The quartic equation with coefficients a = " + a[i] + " b = " + b[i] + " c = " + c[i]);
                Console.WriteLine("Has " + FindNumOfQuarticSolutions(a[i], b[i], c[i]) + " solutions.");
            }
        }
        #endregion

        #region Integral of a Function
        /// <param name="b"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>the definite integral of the function
        /// f(x)=(b+1)*x^b with respect to x from x=m to x=n, 
        /// where b, m, and n are constants</returns>
        static int Integral(int b, int m, int n)
        {
            // Assume that b will be an integer greater than or equal to 0
            // m and n can be any integer, both positive and negative. 
            return 0;
        }
        static void TestIntegral()
        {
            Console.WriteLine("============ Integral of a Function ============");
            Console.WriteLine("Here we will calculate the definite integral of the function f(x)=(b+1)*x^b");
            Console.WriteLine("with respect to x, from x=m,x=n, where b, n and m are constants.");
            int[] b = new int[] { 0, 2, 5 };
            int[] m = new int[] { 2, 4, 9 };
            int[] n = new int[] { 5, 7, 3 };
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("The integral of the function f(x)=(b+1)*x^b from the interval x = m to x = n, where");
                Console.Write("b = " + b[i] + "   m = " + m[i] + "   n = " + n[i] + "");
                Console.WriteLine("is " + Integral(b[i], m[i], n[i]));
            }
        }
        #endregion

        #region Maximum Travel Distance
        /// <param name="fuel">Liters of fuel in the tank</param>
        /// <param name="fuelUsage">Basic fuel consumption at a rate of liters/100km</param>
        /// <param name="passengers">Amount of passengers not including the driver</param>
        /// <param name="airCon">True if the air conditioner is on</param>
        /// <returns>Maximum distance the car can travel</returns>
        static float MaxDistance(float fuel, float fuelUsage, int passengers, bool airCon)
        {
            /* "Basic" fuel consumption is the amount that happens with only the driver inside
             * Each additional passenger increases fuel consumption by 5%
             * If the AC is on, it increases the total (not basic) fuel consumption by 10% 
             * fuel and fuelUsage are always greater than 1
             * passengers are always greater or equal to 0
             * round answer to the nearest tenth
             */

            return 0;
        }
        static void TestMaxDistance()
        {
            Console.WriteLine("============ Maximum Travel Distance ============");
            float fuel, fuelUsage;
            int passengers;
            bool airCon;

            Console.WriteLine("============ Test 1 ============");
            fuel = 70.0f;
            fuelUsage = 7.0f;
            passengers = 0;
            airCon = false;
            Console.WriteLine("Fuel: " + fuel + " Fuel Usage" + fuelUsage + "liters/100km Air conditioner on? " + airCon.ToString());
            Console.WriteLine("Maximum distance: " + MaxDistance(fuel, fuelUsage, passengers, airCon) + "km");

            Console.WriteLine("============ Test 2 ============");
            fuel = 36.1f;
            fuelUsage = 8.6f;
            passengers = 3;
            airCon = true;
            Console.WriteLine("Fuel: " + fuel + " Fuel Usage" + fuelUsage + "liters/100km Air conditioner on? " + airCon.ToString());
            Console.WriteLine("Maximum distance: " + MaxDistance(fuel, fuelUsage, passengers, airCon) + "km");

            Console.WriteLine("============ Test 3 ============");
            fuel = 55.5f;
            fuelUsage = 5.5f;
            passengers = 5;
            airCon = false;
            Console.WriteLine("Fuel: " + fuel + " Fuel Usage" + fuelUsage + "liters/100km Air conditioner on? " + airCon.ToString());
            Console.WriteLine("Maximum distance: " + MaxDistance(fuel, fuelUsage, passengers, airCon) + "km");
        }
        #endregion

        #region Clock Angle Problem
        /// <summary>
        /// Returns the smallest angle between the hands of an analog
        /// clock at a given time in DEGREES
        /// </summary>
        static int findAngle(int hour, int minute)
        {
            return 0;
        }
        /// Remember:
        /// π rad = 180°
        /// 1° = π/180°
        /// radians = degrees × π / 180°
        /// degrees = radians × 180° / π
        static void TestClockAngle()
        {
            Console.WriteLine("============ Clock Angle Problem ============");
            int[] h = new int[] { 5, 9, 12 };
            int[] m = new int[] { 30, 0, 0 };
            for (int i = 0; i < h.Length; i++)
            {
                DateTime dt = new DateTime(2021, 4, 8, h[i], m[i], 0);
                Console.WriteLine("The smallest angle between the hour and minute hands when the time is " + String.Format("{0:hh:mm}", dt) + " is " + findAngle(h[i], m[i]) + "°");
            }
        }
        #endregion
    }
}
