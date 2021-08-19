MATRIX FUNCTIONS
========================================================
Matrix Transpose
In linear algebra, the transpose of a matrix is an operator which flips a matrix over its diagonal; that is, it switches the row and column indices of the matrix A by producing another matrix, often denoted by A^T.
Task: Create a function that takes a 2D array (matrix A) and returns a 2D array (matrix A^T).
Examples:
transpose([
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
]) ➞ [
  [1, 4, 7],
  [2, 5, 8],
  [3, 6, 9]
]

transpose([
  [1, 2],
  [3, 4],
  [5, 6]
]) ➞ [
  [1, 3, 5],
  [2, 4, 6]
]
========================================================
Matrix Multiplication/Division
Task: Write two functions, both taking in a 2d array of integers representing matrices. One will multiply the given matrices, the other will divide them. (Hint: division of matrix A by matrix B really means multiply matrix A by the inverse of matrix B)
========================================================
Matrix Determinants
In linear algebra, the determinant is a scalar value that can be computed from elements in a square matrix. The determinant is useful for solving linear equations, capturing how linear transformation change area or volume, and changing variables in integrals.
Task: Create a function that takes a square 2d array and returns the determinant
Examples: 
determinant([[3]]) ➞ 3
determinant([
		[1, 0]
		[5, 4]
		]) ➞ 4

determinant([
		[4, 8, 6]
		[2, 4, 3]
		[6, 2, 1]
		]) ➞ 0

Notes: All inputs must be square integer matrices
========================================================
Matrix Rotate
Task: Create a function to rotate a square two-dimensional matrix of integer elements num times, where if num is positive, the rotation is clockwise, and if not, counterclockwise.
Examples: 
rotateTransform({
 		 {2, 4},
  		 {0, 0}
   		}, 1) ➞ {
 			 {0, 2},
 			 {0, 4}
			 }
