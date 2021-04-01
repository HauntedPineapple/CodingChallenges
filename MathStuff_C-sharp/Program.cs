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
            //TestQuadraticRootFinder();
            //Console.WriteLine();
            //TestQuadraticSolver();
            //Console.WriteLine();
            //TestQuadraticVertex();
            //Console.WriteLine();
            //TestQuadraticRootSum();
            //Console.WriteLine();
            //TestQuarticSolver();
            //Console.WriteLine();
            //TestIntegral();
            //Console.WriteLine();
            //TestMaxDistance();
            //Console.WriteLine();
            //TestClockAngle();

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

            Console.WriteLine("============ Test 1 ============");
            Console.WriteLine("4x-7=x+11 -> " + LinearEquationSolver("4x-7=x+11"));

            Console.WriteLine("============ Test 2 ============");
            Console.WriteLine("3x=2x+x -> " + LinearEquationSolver("3x=2x+x"));

            Console.WriteLine("============ Test 3 ============");
            Console.WriteLine("3x=3x+2 -> " + LinearEquationSolver("3x=3x+2"));
        }
        #endregion

        #region Quadratic Equation
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>Root value of the equation ax^2 + bx + c</returns>
        static string FindQuadraticRoot(int a, int b, int c)
        {
            string result = "NULL";
            // If the discriminant is negative, there are two complex solutions
            // so return "Null"
            return result;
        }
        static void TestQuadraticRootFinder()
        {
            Console.WriteLine("============ Quadratic Equation ============");
            int a, b, c;
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");

            Console.WriteLine("============ Test 1 ============");
            a = 1;
            b = -12;
            c = -28;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has the root(s): x = " + FindQuadraticRoot(a, b, c));

            Console.WriteLine("============ Test 2 ============");
            a = 2;
            b = -7;
            c = 3;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has the root: x = " + FindQuadraticRoot(a, b, c));

            Console.WriteLine("============ Test 3 ============");
            a = 1;
            b = 2;
            c = -3;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has the root: x = " + FindQuadraticRoot(a, b, c));
        }
        #endregion

        #region How Many Solutions Does This Quadratic Have?
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>The number of solutions to the equation ax^2 + bx + c</returns>
        static int FindNumOfQuadraticSolutions(int a, int b, int c)
        {
            return 0;
        }
        static void TestQuadraticSolver()
        {
            Console.WriteLine("============ How Many Solutions Does This Quadratic Have? ============");
            int a, b, c;
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");

            Console.WriteLine("============ Test 1 ============");
            a = 1;
            b = 0;
            c = -1;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuadraticSolutions(a, b, c) + " solution(s).");

            Console.WriteLine("============ Test 2 ============");
            a = 1;
            b = 0;
            c = 0;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuadraticSolutions(a, b, c) + " solution(s).");

            Console.WriteLine("============ Test 3 ============");
            a = 1;
            b = 0;
            c = 1;
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuadraticSolutions(a, b, c) + " solution(s).");
        }
        #endregion

        #region Vertex of a Quadratic
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        /// <returns>The vertex of the quadratic curve represented by the equation ax^2 + bx + c
        /// with the fist number in the array being the x-value and the second value being the y-value</returns>
        static float[] FindQuadraticVertex(int a, int b, int c)
        {
            // round answers to two decimal places
            return new float[] { 0, 0 };
        }
        static void TestQuadraticVertex()
        {
            Console.WriteLine("============ Vertex of a Quadratic ============");
            int a, b, c;
            float[] solution;
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");

            Console.WriteLine("============ Test 1 ============");
            a = 1;
            b = 0;
            c = 25;
            solution = FindQuadraticVertex(a, b, c);
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has a vertex at (" + solution[0] + ", " + solution[1] + ")");

            Console.WriteLine("============ Test 2 ============");
            a = -1;
            b = 0;
            c = 25;
            solution = FindQuadraticVertex(a, b, c);
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has a vertex at (" + solution[0] + ", " + solution[1] + ")");

            Console.WriteLine("============ Test 3 ============");
            a = 1;
            b = 10;
            c = 4;
            solution = FindQuadraticVertex(a, b, c);
            Console.WriteLine("The quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("has a vertex at (" + solution[0] + ", " + solution[1] + ")");
        }
        #endregion

        #region Sum of Quadratic Roots
        /// <param name="a">coefficient of x^2</param>
        /// <param name="b">coefficient of x</param>
        /// <param name="c">constant term</param>
        static float SumOfQuadraticRoots(int a, int b, int c)
        {
            /*Round answer to two decimal places.
	        If there is only one real root return 1.
        	If there are no real roots, return 0.*/
            return 0;
        }
        static void TestQuadraticRootSum()
        {
            Console.WriteLine("============ Sum of Quadratic Roots ============");
            int a, b, c;
            Console.WriteLine("A quadratic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^2");
            Console.WriteLine("\"b\" is the coefficient of x");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^2 + bx + c");

            Console.WriteLine("============ Test 1 ============");
            a = 2;
            b = 4;
            c = -6;
            Console.WriteLine("The sum of the roots of the quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.Write("is " + SumOfQuadraticRoots(a, b, c));

            Console.WriteLine("============ Test 2 ============");
            a = 3;
            b = 4;
            c = -3;
            Console.WriteLine("The sum of the roots of the quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.Write("is " + SumOfQuadraticRoots(a, b, c));

            Console.WriteLine("============ Test 3 ============");
            a = 4;
            b = 3;
            c = 8;
            Console.WriteLine("The sum of the roots of the quadratic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.Write("is " + SumOfQuadraticRoots(a, b, c));
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
            int a, b, c;
            Console.WriteLine("A quartic equation can be represented by the coefficients \"a\", \"b\" and \"c\"");
            Console.WriteLine("\"a\" is the coefficient of x^4");
            Console.WriteLine("\"b\" is the coefficient of x^2");
            Console.WriteLine("\"c\" is the constant term");
            Console.WriteLine("And can be written as ax^4 + bx^2 +c");

            Console.WriteLine("============ Test 1 ============");
            a = 1;
            b = -5;
            c = 4;
            Console.WriteLine("The quartic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuarticSolutions(a, b, c) + " solutions.");

            Console.WriteLine("============ Test 2 ============");
            a = 4;
            b = 3;
            c = -1;
            Console.WriteLine("The quartic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuarticSolutions(a, b, c) + " solutions.");

            Console.WriteLine("============ Test 3 ============");
            a = 1;
            b = 10;
            c = 9;
            Console.WriteLine("The quartic equation with coefficients a = " + a + " b = " + b + " c =" + c);
            Console.WriteLine("Has " + FindNumOfQuarticSolutions(a, b, c) + " solutions.");
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
            int b, m, n;
            Console.WriteLine("Here we will calculate the definite integral of the function f(x)=(b+1)*x^b");
            Console.WriteLine("with respect to x, from x=m,x=n, where b, n and m are constants.");

            Console.WriteLine("============ Test 1 ============");
            b = 0;
            m = 2;
            n = 5;
            Console.WriteLine("The integral of the function f(x)=(b+1)*x^b from the interval x = m to x = n, where");
            Console.WriteLine("b = " + b + "   m = " + m + "   n = " + n + "");
            Console.WriteLine("is " + Integral(b, m, n));

            Console.WriteLine("============ Test 2 ============");
            b = 2;
            m = 4;
            n = 7;
            Console.WriteLine("The integral of the function f(x)=(b+1)*x^b from the interval x = m to x = n, where");
            Console.WriteLine("b = " + b + "   m = " + m + "   n = " + n + "");
            Console.WriteLine("is " + Integral(b, m, n));

            Console.WriteLine("============ Test 3 ============");
            b = 5;
            m = 9;
            n = 3;
            Console.WriteLine("The integral of the function f(x)=(b+1)*x^b from the interval x = m to x = n, where");
            Console.WriteLine("b = " + b + "   m = " + m + "   n = " + n + "");
            Console.WriteLine("is " + Integral(b, m, n));
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
            int h, m;
            Console.WriteLine("============ Test 1 ============");
            h = 5;
            m = 30;
            Console.WriteLine("The smallest angle between the hour and minute hands when the time is "+h+":"+m+" is "+findAngle(h,m)+ "°");

            Console.WriteLine("============ Test 2 ============");
            h = 9;
            m = 00;
            Console.WriteLine("The smallest angle between the hour and minute hands when the time is " + h + ":" + m + " is " + findAngle(h, m) + "°");

            Console.WriteLine("============ Test 3 ============");
            h = 125;
            m = 00;
            Console.WriteLine("The smallest angle between the hour and minute hands when the time is " + h + ":" + m + " is " + findAngle(h, m) + "°");
        }
        #endregion
    }
}
