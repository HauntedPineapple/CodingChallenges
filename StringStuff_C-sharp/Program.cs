using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StringStuff_C_sharp
{
    class Program
    {
        static char[] Alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                                              'h', 'i', 'j', 'k', 'l', 'm', 'n',
                                              'o', 'p', 'q', 'r', 's', 't', 'u',
                                              'v', 'w', 'x', 'y', 'z' };

        static void Main(string[] args)
        {
            TestFindVowelSubstring();
            Console.WriteLine();

            TestStringCycler();
            Console.WriteLine();

            TestLongestCommonString();
            Console.WriteLine();

            TestMissingAlphabet();
            Console.WriteLine();

            TestIsTriangleWord();
            Console.WriteLine();

            TestCountUnique();
            Console.WriteLine();

            TestIsPalindrome();
            Console.WriteLine();

            TestPalindromicSubstring();
            Console.WriteLine();

            TestMinimumPalindrome();
            Console.WriteLine();

            TestDistanceToNearestVowel();
            Console.WriteLine();

            TestIsValidHexCode();
            Console.WriteLine();

            TestKaracaEncrypt();
            Console.WriteLine();

            TestPermutations();
            Console.WriteLine();

            TestMaximumOccurance();
            Console.WriteLine();

            TestReverseString();

            Console.ReadLine();
        }

        #region Vowel Substrings - Done
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
            string[] s = new string[] { "caberqiitefg", "aeiouia", "azerdii", "qwdftr" };
            int[] k = new int[] { 5, 3, 5, 2 };
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i] + " --> " + FindVowelSubstring(s[i], k[i]));
            }
        }
        #endregion

        #region String Cycling - Done
        static string StringCycler(string str_1, string str_2)
        {
            string result = "";
            int count = 0;
            while (count < str_2.Length)
            {
                for (int i = 0; i < str_1.Length; i++)
                {
                    if (count == str_2.Length)
                    {
                        break;
                    }
                    result += str_1[i];
                    count++;
                }
            }
            return result;
        }
        static void TestStringCycler()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ String Cycling ~~~~~~~~~~~~~~~~~");
            string[] words_1 = new string[] { "abc", "programming", "ha" };
            string[] words_2 = new string[] { "hello", "edabit", "good morning" };
            for (int i = 0; i < words_1.Length; i++)
            {
                Console.WriteLine("StringCycler(\"" + words_1[i] + "\", \"" + words_2[i] + "\") -> \"" + StringCycler(words_1[i], words_2[i]) + "\"");
            }
        }
        #endregion

        #region Longest Common String
        static string LongestCommonString(string str_1, string str_2)
        {
            str_1 = str_1.ToLower();
            str_2 = str_2.ToLower();
            string result = "";
            return result;
        }
        static void TestLongestCommonString()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Longest Common String ~~~~~~~~~~~~~~~~~");
            string[] words_1 = new string[] { "Secretary", "Polymorphism", "Function", "Transformation" };
            string[] words_2 = new string[] { "Intersection", "Abundant", "Hesitate", "Information" };
            for (int i = 0; i < words_1.Length; i++)
            {
                Console.WriteLine("LongestCommonString(\"" + words_1[i] + "\", \"" + words_2[i] + "\") -> \"" + LongestCommonString(words_1[i], words_2[i]) + "\"");
            }
        }
        #endregion

        #region Missing Alphabets
        static string MissingAlphabet(string str)
        {
            str = str.ToLower();
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

        #region Triangle Words - Done
        static bool IsTriangleWord(string str)
        {
            Dictionary<char, int> alphabetValues = new Dictionary<char, int>();
            for (int i = 0; i < Alphabet.Length; i++)
            {
                alphabetValues.Add(Alphabet[i], i + 1);
            }

            int total = 0;
            str = str.ToLower();
            foreach (var letter in str)
            {
                foreach (KeyValuePair<char, int> kvp in alphabetValues)
                {
                    if (letter == kvp.Key)
                    {
                        total += kvp.Value;
                        //continue;
                    }
                }
            }
            total *= 2;
            total = -total;
            /// A triangle number is defined as t(n) = 1/2*n(n+1)
            /// We will use this knowledge to determine if the total is
            /// a triangle word. If the total is a triangle number, that means
            /// the word is a triangle word.
            /// We will use the quadratic equation with a and b being 1, and
            /// the total will be represented by c, the constant
            /// If we get a whole number back, the word is a triangle word

            double root = 0;
            // If the discriminant, b2−4ac, is negative, 
            //there are two complex solutions so return "false"
            if (Math.Sqrt(1 - 4 * 1 * (double)total) < 0)
            {
                return false;
            }

            // Quadratic equation: (-b+√(b^2-4ac))/2a
            root = -1 + Math.Sqrt(1 - 4 * 1 * (double)total);
            root = root / 2;
            if (root % 2 == 0 || root % 2 == 1)
            {
                return true;
            }

            return false;
        }

        static void TestIsTriangleWord()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Triangle Words ~~~~~~~~~~~~~~~~~");
            try
            {
                string filename = "D:\\Repos\\CodingChallenges\\StringStuff_C-sharp\\p042_words.txt";
                FileStream inStream = File.OpenRead(filename);
                StreamReader input = new StreamReader(inStream);

                string allText = input.ReadToEnd();
                string[] allWords = allText.Split(',');

                int numTriangleWords = 0;
                int numWords = 0;
                foreach (string word in allWords)
                {
                    numWords++;
                    if (IsTriangleWord(word))
                    {
                        numTriangleWords++;
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine(word + " IS a triangle word");
                        //Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine(word + " is NOT a triangle word");
                        //Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                Console.WriteLine("There are " + numTriangleWords + " triangle words out of " + numWords + " in p042_words.txt");
                input.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading file!");
                return;
            }

            string[] words = new string[] { "ABILITY", "BECOME", "CHECK", "CHILD",
                                          "GROWING", "ISSUE", "NECESSARILY", "OURSELVES",
                                          "PERFORM","PROPERTY","QUALITY","REDUCTION","SOUTHERN"};
            foreach (string word in words)
            {
                if (IsTriangleWord(word))
                {
                    Console.WriteLine(word + " IS a triangle word");
                }
                else
                {
                    Console.WriteLine(word + " is NOT a triangle word");
                }
            }
        }
        #endregion

        #region Unique Characters - Done
        static int CountUnique(string str_1, string str_2)
        {
            string str = (str_1 + str_2).ToLower();
            List<char> characters = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!characters.Contains(str[i]))
                {
                    characters.Add(str[i]);
                }
            }

            return characters.Count;
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

        #region Is the String a Palindrome? - Done
        static bool IsPalindrome(string str)
        {
            if (str.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
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
            str = str.ToLower();
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
            str = str.ToLower();
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
            int[] distances = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                distances[i] = -1;
            }

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            str = str.ToLower();

            List<int> vowelIndexes = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                foreach (char vowel in vowels)
                {
                    if (str[i] == vowel)
                    {
                        vowelIndexes.Add(i);
                        distances[i] = 0;
                    }
                }
            }

            return distances;
        }
        static void TestDistanceToNearestVowel()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Distance to Nearest Vowel ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "aaaaa", "babbb", "abcdabcd", "shopper" };
            int[] output;
            foreach (var item in words)
            {
                output = DistanceToNearestVowel(item);
                Console.WriteLine(item + " --> ");
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
        }
        #endregion

        #region Valid Hex Code - Done
        static bool IsValidHexCode(string str)
        {
            List<char> validChars = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F',
                                                       'a', 'b', 'c', 'd', 'e', 'f',
                                                       '0', '1', '2', '3', '4', '5',
                                                       '6', '7', '8', '9' };
            if (str[0] != '#')
            {
                return false;
            }
            if (str.Length > 7)
            {
                return false;
            }
            int count = 0;
            for (int i = 1; i < str.Length; i++)
            {
                foreach (char character in validChars)
                {
                    if (str[i] == character)
                    {
                        count++;
                        continue;
                    }
                }
            }
            if (count != 6)
            {
                return false;
            }
            return true;
        }
        static void TestIsValidHexCode()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Valid Hex Code ~~~~~~~~~~~~~~~~~");
            string[] str = new string[]{ "#CD5C5C",
                                         "#EAECEE",
                                         "#eaecee",
                                         "#CD5C58C",
                                         "#CD5C5Z",
                                         "#CD5C&C",
                                         "CD5C5C"};
            foreach (var code in str)
            {
                Console.WriteLine(code + " --> " + IsValidHexCode(code));
            }
        }
        #endregion

        #region The Karaca's Encryption Algorithm - Done
        static string KaracaEncrypt(string str)
        {
            str = ReverseString(str);
            str = str.ToLower();
            String output = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        output += 0;
                        break;
                    case 'e':
                        output += 1;
                        break;
                    case 'i':
                        output += 2;
                        break;
                    case 'o':
                        output += 2;
                        break;
                    case 'u':
                        output += 3;
                        break;
                    default:
                        output += str[i];
                        break;
                }
            }
            output += "aca";
            return output;
        }
        static void TestKaracaEncrypt()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Karaca's Encryption Algorithm ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "banana", "karaca", "burak", "alpaca" };
            foreach (var word in words)
            {
                Console.WriteLine(word + " --> " + KaracaEncrypt(word));
            }
        }
        #endregion

        #region Character Permutations
        static string[] Permutations(string str)
        {
            str = str.ToLower();
            return new string[] { };
        }
        static void TestPermutations()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Character Permutations ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "ab", "cd", "not", "yaw", "liup" };
            string[] output;
            foreach (var item in words)
            {
                output = Permutations(item);
                Console.WriteLine("All the permutations of \"" + item.ToUpper() + "\" are: ");
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
            string[] words = new string[] { "Computer Science", "Edabit", "System admin", "the quick brown fox jumps over the lazy dog" };
            foreach (var item in words)
            {
                Console.WriteLine("The most common character(s) in " + item + " is/are " + MaximumOccurance(item));
            }
        }
        #endregion

        #region Recursive Reverse - Done
        /// <summary>
        /// Reverses the given string using a a recursive method
        /// </summary>
        static string ReverseString(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
            else
                return str;
        }
        static void TestReverseString()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~ Recursive Reverse ~~~~~~~~~~~~~~~~~");
            string[] words = new string[] { "Vertex", "permutations", "function", "Hello World!",
                                            "Racecar", "please hire me", "video games", "recursion"};
            foreach (var str in words)
            {
                Console.WriteLine(str + " -> " + ReverseString(str));
            }
        }
        #endregion
    }
}
