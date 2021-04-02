using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStuff_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFindVowelSubstring();
            //Console.WriteLine();
            //TestStringCycler();
            //Console.WriteLine();
            //TestLongestCommonString();
            //Console.WriteLine();
            //TestMissingAlphabet();
            //Console.WriteLine();
            //TestIsTriangleWord();
            //Console.WriteLine();
            //TestCountUnique();
            //Console.WriteLine();
            //TestIsPalindrome();
            //Console.WriteLine();
            //TestPalindromeBuilder();
            //Console.WriteLine();
            //TestDistanceToNearestVowel();
            //Console.WriteLine();
            //TestIsValidHexCode();
            //Console.WriteLine();
            //TestKaracaEncrypt();
            //Console.WriteLine();
            //TestPermutations();
            //Console.WriteLine();
            //TestMaximumOccurance();
            //Console.WriteLine();
            //TestReverseString();

            Console.ReadLine();
        }

        #region Vowel Substrings
        /// <summary>
        /// Finds the substring in a given string 
        /// that contains the most vowels
        /// If there are multiple strings with the same number
        /// of maximum vowels, returns the one with
        /// the lowest index.
        /// If no vowels exist in the string,
        /// returns "Not found".
        /// </summary>
        /// <param name="s">string of lowercase english letters</param>
        /// <param name="k">length of substring to create</param>
        /// <returns>The substring of the given length that
        /// contains the most vowels</returns>
        public static string FindVowelSubstring(string s, int k)
        {
            string result = "Not found!";
            // contains the substrings and the number of vowels in those substrings
            Dictionary<string, int> substrings = new Dictionary<string, int>();
            List<string> results = new List<string>();
            string newString;
            int numVowels = 0;
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < 5; i++)
            {
                if (s.Contains(vowels[i]))
                {
                    numVowels++;
                }
            }
            if (numVowels == 0)
            { // if no vowels exist, exit
                return result;
            }
            numVowels = 0;

            for (int i = 0; i < (s.Length - k + 1); i++)
            {
                newString = s.Substring(i, k);
                //Console.WriteLine("Substring: " + newString);
                for (int j = 0; j < newString.Length; j++)
                {
                    char[] newStringChars = newString.ToCharArray();
                    for (int a = 0; a < 5; a++)
                    {
                        if (newStringChars[j] == vowels[a])
                        {
                            numVowels++;
                        }
                    }
                }
                substrings.Add(newString, numVowels);
                //Console.WriteLine("Number of vowels: " + numVowels);
                numVowels = 0;
            }

            int max = int.MinValue;
            foreach (KeyValuePair<string, int> substring in substrings)
            {
                if (substring.Value > max)
                {
                    max = substring.Value;
                }
            }
            //Console.WriteLine("Max number of vowels"+max);
            foreach (KeyValuePair<string, int> substring in substrings)
            {
                if (substring.Value == max)
                {
                    results.Add(substring.Key);
                }
            }

            //foreach (string st in results)
            //{
            //    Console.WriteLine("Result: " + st);
            //}

            return results[0];
        }
        static void TestFindVowelSubstring()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Vowel Substrings ~~~~~~~~~~~~~~~~~");
            string s = "caberqiitefg";
            int k = 5;
            Console.WriteLine(FindVowelSubstring(s, k));

            s = "aeiouia";
            k = 3;
            Console.WriteLine(FindVowelSubstring(s, k));

            s = "azerdii";
            k = 5;
            Console.WriteLine(FindVowelSubstring(s, k));

            s = "qwdftr";
            k = 2;
            Console.WriteLine(FindVowelSubstring(s, k));
        }
        #endregion

        #region String Cycling
        static string StringCycler(string str_1, string str_2)
        {
            return "";
        }
        static void TestStringCycler()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ String Cycling ~~~~~~~~~~~~~~~~~");
            string str_1, str_2;
            Console.WriteLine("============== Test 1 ==============");
            str_1 = "abc";
            str_2 = "hello";
            Console.WriteLine("StringCycler(\"" + str_1 + "\", \"" + str_2 + "\") -> \"" + StringCycler(str_1, str_2) + "\"");

            Console.WriteLine("============== Test 2 ==============");
            str_1 = "programming";
            str_2 = "edabit";
            Console.WriteLine("StringCycler(\"" + str_1 + "\", \"" + str_2 + "\") -> \"" + StringCycler(str_1, str_2) + "\"");

            Console.WriteLine("============== Test 3 ==============");
            str_1 = "good morning";
            str_2 = "ha";
            Console.WriteLine("StringCycler(\"" + str_1 + "\", \"" + str_2 + "\") -> \"" + StringCycler(str_1, str_2) + "\"");
        }
        #endregion

        #region Longest Common String
        static string LongestCommonString(string str_1, string str_2)
        {
            return "";
        }
        static void TestLongestCommonString()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Longest Common String ~~~~~~~~~~~~~~~~~");
            string str_1, str_2;
            Console.WriteLine("============== Test 1 ==============");
            str_1 = "Secretary";
            str_2 = "Intersection";
            Console.WriteLine("LongestCommonString(\"" + str_1 + "\", \"" + str_2 + "\") -> \"" + StringCycler(str_1, str_2) + "\"");

            Console.WriteLine("============== Test 2 ==============");
            str_1 = "Polymorphism";
            str_2 = "Abundant";
            Console.WriteLine("LongestCommonString(\"" + str_1 + "\", \"" + str_2 + "\") -> \"" + StringCycler(str_1, str_2) + "\"");
        }
        #endregion

        #region Missing Alphabets
        static string MissingAlphabet(string str)
        {
            return "";
        }
        static void TestMissingAlphabet()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Missing Alphabets ~~~~~~~~~~~~~~~~~");
            string[] str = new string[] { "abcdefghijklmnopqrstuvwxy", "edabit" };
            foreach (string word in str)
            {
                Console.WriteLine(word + "-->" + MissingAlphabet(word));
            }
        }
        #endregion

        #region Triangle Words
        static bool IsTriangleWord(string str)
        {
            return false;
        }
        static void TestIsTriangleWord()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Triangle Words ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "SKY", "ARISE", "DENY", "RESPONSE",
                                          "OBTAIN", "SOMETHING", "WHOSE", "ORGANIZATION",
                                          "CONFLICT","EARLY","JOB","CURRICULUM","LABOUR"};
            foreach (string word in words)
            {
                if (IsTriangleWord(word))
                {
                    Console.WriteLine(word+" is a triangle word");
                }
                else
                {
                    Console.WriteLine(word + " is not a triangle word");
                }
            }

        }
        #endregion

        #region Unique Characters
        static int CountUnique(string str_1, string str_2)
        {
            return 0;
        }
        static void TestCountUnique()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Unique Characters ~~~~~~~~~~~~~~~~~");
            string[] str_1 = new string[] { "apple", "sore", "a" };
            string[] str_2 = new string[] { "play", "zebra", "soup" };
            for (int i = 0; i < str_1.Length; i++)
            {
                Console.WriteLine(str_1[i] + str_2[i] + " --> " + CountUnique(str_1[i], str_2[i]));
            }
        }
        #endregion

        #region Is the String a Palindrome?
        static bool IsPalindrome(string str)
        {
            if (str.Length == 1)
            {
                return true;
            }
            return false;
        }
        static void TestIsPalindrome()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Is the String a Palindrome? ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "racecar", "Fibonacci", "tacocat", "minimum" };
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word + " is a palindrome");
                }
                else
                {
                    Console.WriteLine(word + " is not a palindrome");
                }
            }
        }
        #endregion

        #region Palindromic Substring
        static string PalindromicSubstring(string str)
        {
            return "";
        }
        static void TestPalindromicSubstring()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Palindromic Substring ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "different", "secretary", "polymorphism" };
            foreach (string word in words)
            {
                Console.WriteLine(word + " --> \"" + PalindromicSubstring(word) + "\"");
            }

        }
        #endregion

        #region Make it a Palindrome
        static int MinimumPalindrome(string str)
        {
            return 0;
        }
        static void TestMinimumPalindrome()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Make it a Palindrome ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "ervervige", "aaabab", "x" };
            foreach (string word in words)
            {
                Console.WriteLine(word + " --> " + MinimumPalindrome(word));
            }
        }
        #endregion

        #region Distance to Nearest Vowel
        static int[] DistanceToNearestVowel(string str)
        {
            return null;
        }
        static void TestDistanceToNearestVowel()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Distance to Nearest Vowel ~~~~~~~~~~~~~~~~~");
            string str;
            int[] output;

            Console.WriteLine("============== Test 1 ==============");
            str = "";
            output = DistanceToNearestVowel(str);
            Console.WriteLine(str + " --> ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("============== Test 2 ==============");
            str = "";
            output = DistanceToNearestVowel(str);
            Console.WriteLine(str + " --> ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("============== Test 3 ==============");
            str = "";
            output = DistanceToNearestVowel(str);
            Console.WriteLine(str + " --> ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("============== Test 1 ==============");
            str = "";
            output = DistanceToNearestVowel(str);
            Console.WriteLine(str + " --> ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
        }
        #endregion

        #region Valid Hex Code
        static bool IsValidHexCode(string str)
        {
            return false;
        }
        static void TestIsValidHexCode()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Valid Hex Code ~~~~~~~~~~~~~~~~~");
            string str;
            Console.WriteLine("============== Test 1 ==============");
            str = "#CD5C5C";
            Console.WriteLine(str + " ---> " + IsValidHexCode(str));

            Console.WriteLine("============== Test 2 ==============");
            str = "#CD5C58C";
            Console.WriteLine(str + " ---> " + IsValidHexCode(str));

            Console.WriteLine("============== Test 3 ==============");
            str = "CD5C5C";
            Console.WriteLine(str + " ---> " + IsValidHexCode(str));
        }
        #endregion

        #region The Karaca's Encryption Algorithm
        static string KaracaEncrypt(string str)
        {
            return "";
        }
        static void TestKaracaEncrypt()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Karaca's Encryption Algorithm ~~~~~~~~~~~~~~~~~");
            string str;
            Console.WriteLine("============== Test 1 ==============");
            str = "banana";
            Console.WriteLine(str + " ---> " + KaracaEncrypt(str));
            Console.WriteLine("============== Test 2 ==============");
            str = "karaca";
            Console.WriteLine(str + " ---> " + KaracaEncrypt(str));
            Console.WriteLine("============== Test 3 ==============");
            str = "burak";
            Console.WriteLine(str + " ---> " + KaracaEncrypt(str));

        }
        #endregion

        #region Character Permutations
        static string[] Permutations(string str)
        {
            return null;
        }
        static void TestPermutations()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Character Permutations ~~~~~~~~~~~~~~~~~");
            string str;
            string[] output;

            Console.WriteLine("============== Test 1 ==============");
            str = "ab";
            output = Permutations(str);
            Console.WriteLine("All the permutations of \"" + str.ToUpper() + "\" are: ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine("");

            Console.WriteLine("============== Test 2 ==============");
            str = "jwy";
            output = Permutations(str);
            Console.WriteLine("All the permutations of \"" + str.ToUpper() + "\" are: ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine("");

            Console.WriteLine("============== Test 3 ==============");
            str = "luip";
            output = Permutations(str);
            Console.WriteLine("All the permutations of \"" + str.ToUpper() + "\" are: ");
            for (int i = 0; i < output.Length; i++)
            {
                if (i + 1 == output.Length)
                {
                    Console.Write(output[i]);
                }
                else
                {
                    Console.Write(output[i] + ", ");
                }
            }
            Console.WriteLine("");
        }
        #endregion

        #region Maximum Occurrence
        static string MaximumOccurance(string str)
        {
            return "No repetition";
        }
        static void TestMaximumOccurance()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Maximum Occurrence ~~~~~~~~~~~~~~~~~");
            string str;
            Console.WriteLine("============== Test 1 ==============");
            str = "Computer Science";
            Console.WriteLine("The most common character(s) in " + str + " is/are " + MaximumOccurance(str));

            Console.WriteLine("============== Test 2 ==============");
            str = "Edabit";
            Console.WriteLine("The most common character(s) in " + str + " is/are " + MaximumOccurance(str));

            Console.WriteLine("============== Test 3 ==============");
            str = "System admin";
            Console.WriteLine("The most common character(s) in " + str + " is/are " + MaximumOccurance(str));

            Console.WriteLine("============== Test 4 ==============");
            str = "the quick brown fox jumps over the lazy dog";
            Console.WriteLine("The most common character(s) in " + str + " is/are " + MaximumOccurance(str));
        }
        #endregion

        #region Recursive Reverse
        static string ReverseString(string str)
        {
            return "";
        }
        static void TestReverseString()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Recursive Reverse ~~~~~~~~~~~~~~~~~");
            string str;
            Console.WriteLine("============== Test 1 ==============");
            str = "Vertex";
            Console.WriteLine(str + " -> " + ReverseString(str));

            Console.WriteLine("============== Test 2 ==============");
            str = "permutations";
            Console.WriteLine(str + " -> " + ReverseString(str));

            Console.WriteLine("============== Test 3 ==============");
            str = "function";
            Console.WriteLine(str + " -> " + ReverseString(str));
        }
        #endregion
    }
}
