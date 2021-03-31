NUMBER FUNCTIONS
========================================================
Prime Numbers
Task: Create a function that returns true if a number is prime, and false otherwise. A prime number is any positive integer that is evenly divisible by only two divisors: 1 and itself. 1 is not considered a prime number.
========================================================
Interprime Numbers
An interprime number is a composite number which is equidistant from two consecutive primes. For example, the interprime 6 is 1 point after 5, a prime, and 1 point before the next prime, 7. Another interprime is 93, which lies midway between primes 89 and 97.

Task: Create a function that takes a number n as input. If n is an interprime number, return an array containing the two consecutive primes between which it lies. If it isn't, return an empty array.

Examples:
	interprime(6) ➞ [5, 7]
	interprime(9) ➞ [7, 11]
	interprime(8) ➞ []
Notes: Interprimes cannot be prime themselves (otherwise the primes would not have been consecutive).
========================================================
Binary Search
Task: Create a function that finds a target number in a list of prime numbers. Implement a binary search algorithm in your function. The target number will be from 2 through 97. If the target is prime then return "yes" else return "no".

Examples: 
	int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }
		IsPrime(primes, 3) ➞ "yes"
		IsPrime(primes, 4) ➞ "no"
		IsPrime(primes, 67) ➞ "yes"
========================================================
Expanded Form of a Number
Task: Create a function that expands a number into a string as shown below:
25 ➞ "20 + 5"
70701 ➞ "70000 + 700 + 1"
685 ➞ "600 + 80 + 5"

Examples:
	expandedForm(70304) ➞ "70000 + 300 + 4"
	expandedForm(1037903) ➞ "1000000 + 30000 + 7000 + 900 + 3"
	expandedForm(802539) ➞ "800000 + 2000 + 500 + 30 + 9" 
========================================================
Consecutive Numbers
Task: Create a function that determines whether elements in an array can be re-arranged to form a consecutive list of numbers where each number appears exactly once.

Examples:
	ConsecNum([5, 1, 4, 3, 2]) ➞ true
	// Can be re-arranged to form [1, 2, 3, 4, 5]
	ConsecNum ([5, 1, 4, 3, 2, 8]) ➞ false
	ConsecNum ([5, 6, 7, 8, 9, 9]) ➞ false
	// 9 appears twice
========================================================
Moran Numbers
A Harshad number is a number which is divisible by the sum of its digits. For example, 132 is divisible by 6 (1+3+2).
A subset of the Harshad numbers are the Moran numbers. Moran numbers yield a prime when divided by the sum of their digits. For example, 133 divided by 7 (1+3+3) yields 19, a prime.

Task: Create a function that takes a number and returns "M" if the number is a Moran number, "H" if it is a (non-Moran) Harshad number, or "Neither".

Examples:
	Moran(132) ➞ "H"
	Moran(133) ➞ "M"
	Moran(134) ➞ "Neither"
========================================================
Nth Fibonacci Number
Task: Create a function to return the Nth number in the Fibonacci sequence as a string.

Examples:
	Fibonacci(10) ➞ "55"
	Fibonacci(20) ➞ "6765"
	Fibonacci(30) ➞ "832040"
	Fibonacci(40) ➞ "102334155"
	Fibonacci(50) ➞ "12586269025"
	Fibonacci(60) ➞ "1548008755920"
Notes: This function is expected to calculate numbers greater than UInt64.MaxValue where n can be as large as but not greater than 200.
========================================================
Perfect Number
Task: Create a function that tests whether or not an integer is a perfect number. A perfect number is a number that can be written as the sum of its factors, (equal to sum of its proper divisors) excluding the number itself.

For example, 6 is a perfect number, since 1 + 2 + 3 = 6, where 1, 2, and 3 are all factors of 6. Similarly, 28 is a perfect number, since 1 + 2 + 4 + 7 + 14 = 28.

========================================================
Is the Number a Palindrome?
Task: Create a function that returns true if a number is a palindrome.
========================================================
