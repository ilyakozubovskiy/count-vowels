using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        /// <summary>
        /// Calculates the count of vowels in the source string.
        ///  'a', 'e', 'i', 'o', and 'u' are vowels. 
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Count of vowels in the given string.</returns>
        /// <exception cref="ArgumentException">Thrown when source string is null or empty.</exception>
        public static int GetCountOfVowel(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("String cannot be null or empty.");
            }

            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (source[i] == vowels[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
