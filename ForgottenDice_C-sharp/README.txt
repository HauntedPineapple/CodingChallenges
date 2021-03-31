You have just rolled a dice several times. The N roll results that you remember are described by an array A. However, there are F rolls whose results you have forgotten. The arithmetic mean of all of the roll results (the sum of all the roll results divided by the number of rolls) equals M.
Task: Write a function that, given an array A of length N, an integer F and an integer M, returns an array containing possible results of the missed rolls. The returned array should contain F integers from 1 to 6 (valid dice rolls). If such an array does not exist then the function should return [O].
Examples: 
	Given A = [3, 2, 4, 3], F = 2, M = 4 ➞ [6,6]
	Given A = [1, 5, 6], F = 4, M = 3 ➞ [2, 1, 2, 4] or [6, 1, 1, 1] (there may be multiple solutions)
	Given A = [1, 2, 3, 4], F = 4, M = 6 ➞ [0]
Assume the following for this problem:
	•	M is an integer within the range [1..6]
	•	Each element of array A is an integer within the range [1..6]
	•	N and F are integers within the range [1..100,000]
