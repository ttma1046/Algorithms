using System;

namespace Algorithms_Csharp.stringDemo
{
    class AnagramProblem
    {
        public static int NUMBER_LETTERS = 26;

        public static int getDelta(int[] arrayA, int[] arrayB)
        {
            if (arrayA.Length != arrayB.Length)
            {
                return -1;
            }
            int delta = 0;

            for (int i = 0; i < arrayA.Length; i++)
            {
                int difference = Math.Abs(arrayA[i] - arrayB[i]);
                delta += difference;
            }

            return delta;
        }

        public static int[] getCharCounts(String s)
        {
            int[] charCounts = new int[NUMBER_LETTERS];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s.CharAt(i);
                int offset = (int)'a';
                int code = c - offset;
                charCounts[code]++;
            }
            return charCounts;
        }

        // Complete the makeAnagram function below.
        static int makeAnagram(String first, String second)
        {
            int[] charCountA = getCharCounts(first);
            int[] charCountB = getCharCounts(second);

            return getDelta(charCountA, charCountB);

        }
    }
}
