STRING STUFF
========================================================
Vowel Substrings
Task: Given a string of lowercase English letters and an integer of the substring length, determine the substring of that length that contains the most vowels. Vowels are in the set {a, e, i, o, u}. If there is more than one substring with the maximum number of vowels, return the one that starts at the lowest index. If there are no vowels in the input string, return the string “Not found!”.

Examples: 
	vowelSubstring(“caberqiitefg”, 5) ➞ “erqii”
	vowelSubstring(“aeiouia”, 3) ➞ “aei”
========================================================
String Cycling
Task: Given two strings, repeatedly cycle through all of the letters in the first string until it is the same length as the second string.

Examples:
	stringCycling("abc", "hello") ➞ "abcab"
	stringCycling("programming", "edabit") ➞ "progra"
	stringCycling("ha", "good morning") ➞ "hahahahahaha"
========================================================
Longest Common String
Task: Given two strings, write a program that efficiently finds the longest common substring. If there are no common substrings, return an empty string.

Example: 
	longestCommonString(“Secretary”,”Intersection”) ➞ “sect”
	longestCommonString(“Polymorphism”,”Abundant”) ➞ “”
========================================================
Missing Alphabets
Task: Create a function that takes a string containing only letters from a to z and returns the missing letter(s) in alphabetical order a-z.

Examples: 
	MissingAlphabets("abcdefghijklmnopqrstuvwxy") ➞ "z"
	// "z" is missing.
	MissingAlphabets("edabit") ➞ "cfghjklmnopqrsuvwxyz"
Note: If the string contains all letters from a-z, return an empty string ""
========================================================
Triangle Words
The nth term of the sequence of triangle numbers is given by, t(n) = ½n(n+1); so the first ten triangle numbers are: 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t(10). If the word value is a triangle number then we shall call the word a triangle word.

Task: Write a function that will take in a string and return whether the word is a triangle word or not.
========================================================
Unique Characters
Task: Given two strings, create a function that returns the total number of unique characters from the combined string.

Examples:
	countUnique("apple", "play") ➞ 5
	//"appleplay" has 5 unique characters:
	// "a", "e", "l", "p", "y"
	countUnique("sore", "zebra") ➞ 7
	// "sorezebra" has 7 unique characters:
	// "a", "b", "e", "o", "r", "s", "z"
	countUnique("a", "soup") ➞ 5
Notes: All input should be lower case
========================================================
Is the String a Palindrome?
Task: Given a word, create a function that checks whether it is a palindrome.
========================================================
Palindromic Substring
Task: Write a function that finds the longest palindromic substring of a given string, if there is none, return an empty string
	Example: palindromicSubstring(“different”) ➞ “ere”
========================================================
Make it a Palindrome
You are given a string “S” containing lowercase English letters. Your task is to calculate the minimum number of letters that need to be removed in order to make it possible to build a palindrome from the remaining letters. When building the palindrome, you can rearrange the remaining letters in any way. 

Task: Write a function int minPalindrome(string s), which, given a string of length “N”, returns the minimum number of letters that need to be removed.

Examples:
	Given S = "ervervige", your function should return 2. After removing the letter "g" and one "e", we may create a word "reviver", which is a palindrome.
	Given S = "aaabab", your function should return O. We may create a word "aabbaa", which is a palindrome and uses all of the letters.
	Given S = "x", your function should return O. String "x" is a palindrome itself, so we do not have to delete any letters.

Notes:
	“S” contains only lowercase English letters.
	“N” is an integer within the range [1..200,000]

========================================================
Distance to Nearest Vowel
Task: Write a function that takes in a string and for each character, returns the distance to the nearest vowel in the string. If the character is a vowel itself, return 0.

Examples:
	DistanceToNearestVowel("aaaaa") ➞ [0, 0, 0, 0, 0]
	DistanceToNearestVowel("babbb") ➞ [1, 0, 1, 2, 3]
	DistanceToNearestVowel("abcdabcd") ➞ [0, 1, 2, 1, 0, 1, 2, 3]
	DistanceToNearestVowel("shopper") ➞ [2, 1, 0, 1, 1, 0, 1]

Notes:
	All input strings will contain at least one vowel.
	Strings will be lowercased.
	Vowels are: a, e, i, o, u.
========================================================
Valid Hex Code
A hex code must begin with a pound key # and is exactly 6 characters in length. Each character must be a digit from 0-9 or an alphabetic character from A-F. All alphabetic characters may be uppercase or lowercase.

Task: Create a function that determines whether a string is a valid hex code.

Examples:
	IsValidHexCode("#CD5C5C") ➞ true
	IsValidHexCode("#EAECEE") ➞ true
	IsValidHexCode("#eaecee") ➞ true
	IsValidHexCode("#CD5C58C") ➞ false
	// Length exceeds 6
	IsValidHexCode("#CD5C5Z") ➞ false
	// Not all alphabetic characters in A-F
	IsValidHexCode("#CD5C&C") ➞ false
	// Contains unacceptable character
	IsValidHexCode("CD5C5C") ➞ false
	// Missing #
========================================================
The Karaca's Encryption Algorithm
Task: Make a function that encrypts a given input with these steps:
Step 1: Reverse the input
Step 2: Replace all vowels using the following chart:
		a => 0
		e => 1
		i => 2
		o => 2
		u => 3
Step 3: Add "aca" to the end of the word

Examples:
	encrypt("banana") ➞ "0n0n0baca"
	encrypt("karaca") ➞ "0c0r0kaca"
	encrypt("burak") ➞ "k0r3baca"
	encrypt("alpaca") ➞ "0c0pl0aca"
Notes: All inputs are strings, no uppercases and all output must be strings.
========================================================
Character Permutations
Task: Given a string, create a function that returns a list that contains all permutations using the characters in the string. Sort the list in alphabetical order.

Examples: 
	permutations("AB") ➞ {"AB", "BA"}
	permutations("CD") ➞ {"CD", "DC"}
	permutations("NOT") ➞ {"NOT", "NTO", "ONT", "OTN", "TNO", "TON"}
	permutations("YAW") ➞ {"AWY", "AYW", "WAY", "WYA", "YAW", "YWA"}
========================================================
Maximum Occurrence
Task: Given a string, write a function that returns the character with the highest frequency. If more than 1 character has the same highest frequency, return all those characters as a comma separated string. If there is no repetition in characters, return "No Repetition".

Examples: 
	maxOccur("Computer Science") ➞ "e"
	maxOccur("Edabit") ➞ "No Repetition"
	maxOccur("system admin") ➞ "m, s"
	maxOccur("the quick brown fox jumps over the lazy dog") ➞ " "
Notes: Characters are case sensitive, so, for example, "C" and "c" are counted separately
========================================================
Recursive Reverse
Task: Given a string s, write a function that will reverse that string using recursion
========================================================