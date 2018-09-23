using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_IsUnique
{
    class Program
    {
        private static int NUMBER_LETTERS = 26;

        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("test"));
        }

        static bool IsStringUnique(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool IsUniqueHash(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return true;

            Dictionary<char, bool> hash = new Dictionary<char, bool>();

            for (int i = 0; i < input.Length; i++)
            {
                if (hash.ContainsKey(input[i]))
                {
                    return false;
                }

                hash.Add(input[i], true);
            }

            return true;
        }

        static int getCharCode(char c)
        {
            int offset = (int)'a';
            int code = c - offset;

            return code;
        }

        static bool IsUniqueArray(string input)
        {
            if (input == "" || input == null)
                return true;

            bool [] charCounts = new bool[NUMBER_LETTERS];
            for (int i = 0; i < input.Length; i++)
            {
                int index = getCharCode(input[i]);
                if (charCounts[index])
                {
                    return false;
                }

                charCounts[index] = true;
            }
            return true;
        }

        static bool IsUnique(string input)
        {
            char[] phrase = input.ToCharArray();

            Array.Sort(phrase);
            for (int i = 0; i < phrase.Length - 1; i++)
                if (phrase[i] == phrase[i + 1])
                    return false;
            return true;
        }

        // Try a hash table.
        // Could a bit vector be useful ?
        // Can you solve it in O(N log N) time? What might a solution like that look like ?
    }
}
