ARRAY STUFF
========================================================
Diamond Shaped Array
Task: Create a function that returns an array that expands by 1 from 1 to the value of the input, and then reduces back to 1. Items in the lists will be the same as the length of the lists.

Examples:
	diamondArrays(1) ➞ [[1]]
	diamondArrays(2) ➞ [[1], [2, 2], [1]]
	diamondArrays(5) ➞ [[1], [2, 2], [3, 3, 3], [4, 4, 4, 4], [5, 5, 5, 5, 5], [4, 4, 4, 4], [3, 3, 3], [2, 2], [1]]

Array Stuff
========================================================
Multiplication Tables
Task: create an N x N multiplication table, of size n provided by a parameter.
For example, when n is 5, the multiplication table is: 
1, 2, 3, 4, 5
2, 4, 6, 8, 10
3, 6, 9, 12, 15
4, 8, 12, 16, 20
5, 10, 15, 20, 25
Output: 
[[1, 2, 3, 4, 5], [2, 4, 6, 8, 10], [3, 6, 9, 12, 15], [4, 8, 12, 16, 20], [5, 10, 15, 20, 25]]

Examples:
	multiplicationTable(1) ➞ [[1]]
	multiplicationTable(3) ➞ [[1, 2, 3], [2, 4, 6], [3, 6, 9]]
========================================================
Array of Multiples
Task: Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.

Examples:
	arrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]
	arrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]
	arrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
Note that “num” is also included in the result
========================================================
Array Summation
Task: Write a function that takes two integer arrays as inputs. Your function will return TRUE if any two of the numbers in the first array, inputs, add up to any of the numbers in the second array, tests, and FALSE otherwise.
Examples: 
	arraySummation({-1, 8, 3}, {3, 7, 2}) ➞ TRUE
	arraySummation({9, 6, 12}, {1, 2, 3}) ➞ FALSE
========================================================
Missing Integer
Task: Write a function that takes an array A of N integers and returns the smallest positive integer that does not occur in A

Examples: 
	Given A = {1, 3, 6, 4, 1, 2}, the function should return 5
	Given A = {1, 2, 3}, the function should return 4
	Given A = {-1, -3}, the function should return 1
Assume that:
	1 <= N <= 100,000
	Each element of array A is in the range of [-1,000,000, 1,000,000]
========================================================
Mini Peaks
Task: Write a function that returns all the elements in an array that are strictly greater than their adjacent left and right neighbors. If no such numbers exist, return an empty array. Do not count boundary numbers, since they only have one left/right neighbor.

Examples:
	miniPeaks([4, 5, 2, 1, 4, 9, 7, 2]) ➞ [5, 9]
	miniPeaks([1, 2, 1, 1, 3, 2, 5, 4, 4]) ➞ [2, 3, 5]
	miniPeaks([1, 2, 3, 4, 5, 6]) ➞ []
========================================================