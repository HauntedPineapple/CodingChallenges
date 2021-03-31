This function takes two intteger arrays as inputs.
It returns TRUE if any two numbers in the first array add up to any one number
in the second array. If none of the numbers match this criteria, the function returns FALSE.

Examples:
	Given:
	array_1 = {-1, 8, 3}
	array_2 = {3, 7, 2}
	returns TRUE because -1 + 3 is 2, also -1 + 8 = 7

	Given:
	array_1 = {9, 6, 12}
	array_2 = {1, 2, 3}
	returns FALSE because no pair of numbers in the first array add up to
	any of the numbers in the second array