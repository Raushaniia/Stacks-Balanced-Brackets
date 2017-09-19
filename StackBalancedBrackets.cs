using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksBalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "{[(])}";
            if (IsBalanced(expression.ToCharArray()))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadLine();
        }

        static bool IsBalanced(char[] chars)
        {
            Stack<char> s = new Stack<char>();
            foreach (char c in chars)
            {
                if (c == '{') s.Push('}');
                else if (c == '(') s.Push(')');
                else if (c == '[') s.Push(']');
                else
                {
                    if (s.Count == 0 || c != (char)s.Peek())
                        return false;
                    s.Pop();
                }
            }
            return s.Count == 0 ? true : false;
        }
    }
}
