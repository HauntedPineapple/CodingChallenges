Given a string "s" of lowercase Emglish letters and an integer "k"
of substring length, determine the substring of the given length that contains the most vowels.
Vowels are defined as being in the set of {a, e, i, o, u}.
If there is more than one substring with the maximum number of vowels, return the
one that starts at the lowest index. If there are no vowels in the input string, return
the string "Not found!".

Constraints:
1 <= length of string <= 2*10^5
1<= k <= length

Examples:
	s = caberqiitefg
	k = 5
	returns "erqii"

	s = aeiouia
	k = 3
	returns "aei"