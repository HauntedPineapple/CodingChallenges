using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFunctions_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 },
                                            { 4, 5, 6 },
                                            { 7, 8, 9 } };
            PrintIntMatrix(matrix);
            Console.WriteLine();
            matrix = new int[3, 2] { { 1, 2 },
                                     { 3, 4},
                                     { 5, 6} };
            PrintIntMatrix(matrix);          

            Console.ReadLine();
        }

        static int[,] MatrixTranspose(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];

            return result;
        }

        static int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
        {
            /// A matrix of MxN dimensions can only be multiplied
            /// by another matrix of NxP dimensions
            if (matrixA.GetLength(1) != matrixB.GetLength(0))
            {
                return null;
            }
            /// When a matrix of MxN dimensions is multiplied by
            /// an array of NxP dimensions, the resulting array
            /// has MxP dimensions
            int[,] resultArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {

                }
            }
            return null;
        }

        static int[,] MatrixDivide(int[,] matrixA, int[,] matrixB)
        {
            return null;
        }

        /// <param name="matrix">MUST be a square matrix</param>
        static int MatrixDeterminant(int[,] matrix)
        {
            return 0;
        }

        /// <summary>
        /// Rotates a given matrix "num" times
        /// </summary>
        /// <param name="matrix">Square matrix to rotate</param>
        /// <param name="num">Number of times to rotate the matrix.
        /// If this value is positive, rotate clockwise. If it is
        /// negative, rotate counterclockwise</param>
        static int[,] MatrixRotate(int[,] matrix, int num)
        {
            return null;
        }

        static void PrintIntMatrix(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("[");
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    count++;
                    if (count < matrix.GetLength(1))
                    {
                        Console.Write(matrix[i,k]+", ");
                    }
                    else
                    {
                        Console.Write(matrix[i,k]);
                    }  
                }
                count = 0;
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
