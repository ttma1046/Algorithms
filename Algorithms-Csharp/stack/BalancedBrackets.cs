using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.stack
{
    /*
        A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

        Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().

        A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. For example, {[(])} is not balanced because the contents in between { and } are not balanced. The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

        Some examples of balanced brackets are []{}(), [({})]{}() and ({(){}[]})[].

        By this logic, we say a sequence of brackets is considered to be balanced if the following conditions are met:

        It contains no unmatched brackets.
        The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
        Given  strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, print YES on a new line; otherwise, print NO on a new line.

                Input Format

        The first line contains a single integer, , denoting the number of strings.
        Each line  of the  subsequent lines consists of a single string, , denoting a sequence of brackets.

                Constraints

        , where  is the Length of the sequence.
        Each character in the sequence will be a bracket (i.e., {, }, (, ), [, and ]).
        Output Format

        For each string, print whether or not the string of brackets is balanced on a new line. If the brackets are balanced, print YES; otherwise, print NO.

        Sample Input

        3
        {[()]}
        {[(])}
        {{[[(())]]}}
        Sample Output

        YES
                NO
        YES
                Explanation

        The string {[()]} meets both criteria for being a balanced string, so we print YES on a new line.
        The string {[(])} is not balanced, because the brackets enclosed by the matched pairs [(] and (]) are not balanced. Thus, we print NO on a new line.
        The string {{[[(())]]}} meets both criteria for being a balanced string, so we print YES on a new line.
    */

    class BalancedBrackets
    {
        public static char[][] TOKENS = new char[][] { new char[] { '{', '}' }, new char[] { '[', ']' }, new char[] { '(', ')' } };

        public static bool isOpenTerm(char c)
        {
            foreach (char[] openTerms in TOKENS)
            {
                if (openTerms[0] == c)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool matches(char openTerm, char closeTerm)
        {
            foreach (char[] array in TOKENS)
            {
                if (array[0] == openTerm)
                {
                    return array[1] == closeTerm;
                }
            }

            return false;
        }

        private static bool isBalanced(String expression)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in expression.ToCharArray())
            {
                if (isOpenTerm(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || !matches(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static String isBalancedBrackets(String expression)
        {
            if (expression == null || expression.Length == 0) return "Yes";

            Stack<char> result = new Stack<char>();

            foreach (char c in expression.ToCharArray())
            {
                switch (c)
                {
                    case '[':
                        result.Push(']');
                        break;
                    case '{':
                        result.Push('}');
                        break;
                    case '(':
                        result.Push(')');
                        break;
                    case ']':
                    case '}':
                    case ')':
                        if (result.Count == 0 || result.Pop() != c)
                        {
                            return "No";
                        }

                        break;
                    default:
                        return "No";
                }
            }

            return result.Count == 0 ? "Yes" : "No";
        }
    }
}
