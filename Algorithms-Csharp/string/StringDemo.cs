using System;
using System.Text;

namespace Algorithms_Csharp.StringDemo
{
    class StringDemo  {
        public static void main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("a");
            sb.Append("b");
            sb.Append("c");
            sb.Append("d");
        }

        string joinWords(string[] words)
        {
            StringBuilder sentence = new StringBuilder();
            foreach (var word in words)
            {
                sentence.Append(word);
            }
            return sentence.ToString();
        }
    }
}
