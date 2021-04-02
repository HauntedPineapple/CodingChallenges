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

        }

        static int[,] matrixMultiply(int[,] matrixA, int[,] matrixB)
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

        static int[,] matrixDivide(int[,] matrixA, int[,] matrixB)
        {
            return null;
        }

        /// <param name="matrix">MUST be a square matrix</param>
        static int matrixDeterminant(int[,] matrix)
        {
            return 0;
        }

        /// <summary>
        /// Returns a rotated matrix
        /// </summary>
        /// <param name="matrix">Square matrix to rotate</param>
        /// <param name="num">Number of times to rotate the matrix.
        /// If this value is positive, rotate clockwise. If it is
        /// negative, rotate counterclockwise</param>
        /// <returns></returns>
        static int[,] matrixRotate(int[,] matrix, int num)
        {
            return null;
        }

        static int[,] matrixTranspose(int[,] matrix)
        {
            return null;
        }
    }
}
