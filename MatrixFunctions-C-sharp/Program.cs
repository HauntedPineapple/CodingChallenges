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
            int[,] matrixA = new int[3, 3] { { 1, 2, 3 },
                                             { 4, 5, 6 },
                                             { 7, 8, 9 } };
            int[,] matrixB = new int[3, 2] { { 1, 4 },
                                             { 2, 5},
                                             { 3, 6} };
            int[,] matrixC = new int[3, 2] { { 1, 0 },
                                             { 2, 4},
                                             { 1, 3} };
            int[,] matrixD = new int[2, 3] { { 1, 0, 2 },
                                             { 4, 3, 1} };

            #region transpose
            Console.WriteLine("======== Matrix Transpose ========");
            Console.WriteLine("The transpose of the matrix: ");
            PrintIntMatrix(matrixA);
            Console.WriteLine("Is: ");
            PrintIntMatrix(MatrixTranspose(matrixA));
            Console.WriteLine("The transpose of the matrix: ");
            PrintIntMatrix(matrixB);
            Console.WriteLine("Is: ");
            PrintIntMatrix(MatrixTranspose(matrixB));
            #endregion

            #region multiplication
            Console.WriteLine("======== Matrix Multiplication ========");
            Console.WriteLine("Given: ");
            Console.WriteLine("Matrix A:");
            PrintIntMatrix(matrixA);
            Console.WriteLine("Matrix B:");
            PrintIntMatrix(matrixB);
            Console.WriteLine("The product of A x B is:");
            PrintIntMatrix(MatrixMultiply(matrixA, matrixB));
            Console.WriteLine("Given: ");
            Console.WriteLine("Matrix A:");
            PrintIntMatrix(matrixD);
            Console.WriteLine("Matrix B:");
            PrintIntMatrix(matrixC);
            Console.WriteLine("The product of A x B is:");
            PrintIntMatrix(MatrixMultiply(matrixD, matrixC));
            #endregion

            #region determinant
            Console.WriteLine("======== Matrix Determinants ========");
            Console.WriteLine("The determinant of the given matrix: ");
            int[,] matrix = new int[2, 2] { { 3, 8 },
                                            { 4, 6 } };
            PrintIntMatrix(matrix);
            Console.WriteLine("Is " + MatrixDeterminant(matrix)); //should be -14

            Console.WriteLine("The determinant of the given matrix: ");
            matrix = new int[3, 3] { { 6, 1, 1 },
                                     { 4, -2, 5 },
                                     { 2, 8, 7 }};
            PrintIntMatrix(matrix);
            Console.WriteLine("Is " + MatrixDeterminant(matrix)); //should be -306

            Console.WriteLine("The determinant of the given matrix: ");
            matrix = new int[4, 4] { { 5, 3, 7, 1 },
                                     { 4, 4, 5, 6 },
                                     { 3, 6, 7, 2 },
                                     { 2, 6, 9, 7 } };
            PrintIntMatrix(matrix);
            Console.WriteLine("Is " + MatrixDeterminant(matrix)); //should be 469

            Console.WriteLine("The determinant of the given matrix: ");
            matrix = new int[5, 5] { { 2, 1, 4, 8, 5 },
                                     { 3, 6, 3, 4, 5 },
                                     { 5, 3, 1, 6, 2 },
                                     { 8, 3, 6, 9, 2 },
                                     { 2, 6, 7, 5, 8 } };
            PrintIntMatrix(matrix);
            Console.WriteLine("Is " + MatrixDeterminant(matrix)); //should be 580
            #endregion

            #region inversion
            Console.WriteLine("======== Matrix Inversion ========");
            Console.WriteLine("");
            #endregion

            #region division
            Console.WriteLine("======== Matrix Division ========");
            Console.WriteLine("");
            #endregion

            #region rotation
            Console.WriteLine("======== Matrix Rotation ========");
            Console.WriteLine("");
            #endregion

            Console.ReadLine();
        }

        static int[,] MatrixTranspose(int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result[i, j] = matrix[j, i];
                }
            }
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
                    int[] row = new int[matrixA.GetLength(1)];
                    int[] col = new int[matrixA.GetLength(1)];
                    for (int a = 0; a < matrixA.GetLength(1); a++)
                    {
                        row[a] = matrixA[i, a];
                        col[a] = matrixB[a, j];
                    }
                    resultArray[i, j] = DotProduct(row, col);
                }
            }
            return resultArray;
        }
        static int DotProduct(int[] vecA, int[] vecB)
        {
            if (vecA.Length != vecB.Length)
            { // Cannot get dot product if the lengths are not the same
                throw new ArgumentException();
            }
            int sum = 0;
            for (int i = 0; i < vecA.Length; i++)
            {
                sum += vecA[i] * vecB[i];
            }
            return sum;
        }

        /// <param name="matrix">MUST be a square matrix</param>
        static int MatrixDeterminant(int[,] matrix)
        {
            if (matrix.GetLength(1) != matrix.GetLength(0))
            {
                throw new ArgumentException();
            }

            

            return 0;
        }

        static double[,] InverseMatrix(int[,] matrix)
        {
            return null;
        }

        static int[,] MatrixDivide(int[,] matrixA, int[,] matrixB)
        {
            return null;
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
                        Console.Write(matrix[i, k] + ", ");
                    }
                    else
                    {
                        Console.Write(matrix[i, k]);
                    }
                }
                count = 0;
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
