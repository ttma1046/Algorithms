using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.hashtable
{
    /*
    Check out the resources on the page's right side to learn more about hashing. The video tutorial is by Gayle Laakmann McDowell, author of the best-selling interview book Cracking the Coding Interview.

    Harold is a kidnapper who wrote a ransom note (勒赎信), but now he is worried it will be traced back to him through his handwriting.

    He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable replica of his ransom note.

    The words in his note are case-sensitive and he must use only whole words available in the magazine.

    He cannot use substrings or concatenation to create the words he needs.

    Given the words in the magazine and the words in the ransom note,

    print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.


    For example, the note is "Attack at dawn".

    The magazine contains only "attack at dawn". The magazine has all the right words, but there's a case mismatch. The answer is "No".


    Function Description

    Complete the checkMagazine function in the editor below. It must print "Yes" if the note can be formed using the magazine, or "No" .

    checkMagazine has the following parameters:

    magazine: an array of strings, each a word in the magazine
    note: an array of strings, each a word in the ransom note
    Input Format

    The first line contains two space-separated integers, m and n, the numbers of words in the magazine  and the note..
    The second line contains m space-separated strings, each magazine[i].
    The third line contains n space-separated strings, each note[i].

    Constraints
    * 1 <= m, n <= 30000
    * 1 <= |magazine[i]|, |note[i]| <= 5
    * Each word consists of English alaphabetic letters (i.e., a to z and A to Z).

    Output Format

    Print Yes if he can use the magazine to create an untraceable replica of his ransom note. Otherwise, print No.

    Sample Input 0

    6 4
    give me one grand today night
    give one grand today
    Sample Output 0

    Yes
    Sample Input 1

    6 5
    two times three is not four
    two times two is four
    Sample Output 1

    No
    Explanation 1

    'two' only occurs once in the magazine.

    Sample Input 2

    7 4
    ive got a lovely bunch of coconuts
    ive got some coconuts
    Sample Output 2

    No
    Explanation 2

    Harold's magazine is missing the word .
     */
    public class RansomNote
    {
        // Complete the checkMagazine function below.
        static void checkMagazine(string[] magazine, string[] note)
        {
            if (magazine == null || magazine.Length == 0 || note == null || note.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Dictionary<string, int> book = new Dictionary<string, int>();

            foreach (string word in magazine)
            {
                if (book.ContainsKey(word))
                {
                    book[word]++;
                }
                else
                {
                    book[word] = 1;
                }
            }

            foreach (string word in note)
            {
                if (!book.ContainsKey(word))
                {
                    Console.WriteLine("No");
                    return;
                }

                book[word]--;
                if (book[word] == 0)
                {
                    book.Remove(word);
                }
            }

            Console.WriteLine("Yes");
        }

        public static Dictionary<string, int> getstringFrequency(string[] text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (!frequencies.ContainsKey(word))
                {
                    frequencies[word] = 0;
                }
                frequencies[word] = frequencies[word] + 1;
            }

            return frequencies;
        }

        public static bool hasEnoughstrings(Dictionary<string, int> magazineFreq, Dictionary<string, int> noteFreq)
        {
            foreach (var entry in noteFreq)
            {
                string word = entry.Key;
                if (!magazineFreq.ContainsKey(word) || magazineFreq[word] < entry.Value)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool canBuildRandomNote(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineFreq = getstringFrequency(magazine);
            Dictionary<string, int> noteFreq = getstringFrequency(note);
            return hasEnoughstrings(magazineFreq, noteFreq);
        }

        public static void main(string[] args)
        {

        }
    }
}
