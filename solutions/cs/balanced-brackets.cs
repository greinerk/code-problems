using System;
using System.Collections.Generic;
namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            if (balanced_calc("()[]{}(([])){[()][]}"))
                Console.WriteLine("Balanced");
            if (balanced_calc("())[]{}"))
                Console.WriteLine("Balanced");
            if (balanced_calc("[(])"))
                Console.WriteLine("Balanced");
            if (balanced_calc("[("))
                Console.WriteLine("Balanced");
        }
        static bool balanced_calc(string input)
        {
            Stack<char> balanced = new Stack<char>();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '{':
                    case '[':
                    case '(':
                        balanced.Push(c);
                        break;
                    case '}':
                        if (balanced.Count == 0 || balanced.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (balanced.Count == 0 || balanced.Pop() != '[')
                            return false;
                        break;
                    case ')':
                        if (balanced.Count == 0 || balanced.Pop() != '(')
                            return false;
                        break;
                }
            }
            if (balanced.Count == 0)
                return true;
            else
                return false;
        }
    }
}
