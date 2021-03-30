using System.Collections.Generic;
using System;

namespace VowelSubstrings
{
    class Program
    {
        /// <summary>
        /// Finds the substring in a given string 
        /// that contains the most vowels.
        /// If there are multiple strings with the same number
        /// of maximum vowels, returns the one with
        /// the lowest index
        /// </summary>
        /// <param name="s">string of lowercase english letters</param>
        /// <param name="k">length of substring to create</param>
        /// <returns>The substring of the given length that
        /// contains the most vowels</returns>
        public static string findSubstring(string s, int k)
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
            {
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

        static void Main(string[] args)
        {
            string s = "caberqiitefg";
            int k = 5;
            Console.WriteLine(findSubstring(s, k));

            s = "aeiouia";
            k = 3;
            Console.WriteLine(findSubstring(s, k));

            s = "azerdii";
            k = 5;
            Console.WriteLine(findSubstring(s, k));

            s = "qwdftr";
            k = 2;
            Console.WriteLine(findSubstring(s, k));
        }
    }
}
