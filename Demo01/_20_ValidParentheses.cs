using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class _20_ValidParentheses
    {
        Dictionary<string, string> parentheses = new Dictionary<string, string>
        {
            { "(", ")" },
            { "[", "]" },
            { "{", "}" }
        };
        List<string> stack = new List<string>();

        public bool IsValid(string s)
        {
            return IsValidMethod2(s);
        }
        public bool IsValidMethod1(string s)
        {
            bool rs = false;
            stack = new List<string>();

            foreach (char c in s)
            {
                //Save OpenParentheses to stack (1) (First In, Last Out)
                if (parentheses.Keys.Contains(c.ToString()))
                {
                    stack.Add(c.ToString());
                }

                //If next charactor is CloseParentheses, and match with last OpenParentheses, remove stack (1)
                if (parentheses.Values.Contains(c.ToString()))
                {
                    var lastOpen = stack.LastOrDefault();
                    if (lastOpen != null)
                    {
                        if (c.ToString() == parentheses[lastOpen])
                        {
                            stack.RemoveAt(stack.Count - 1);
                        }
                        else return false;
                    }
                    else return false;
                }
            }

            if (stack.Count() == 0) rs = true;
            return rs;
        }

        public bool IsValidMethod2 (string s)
        {
            Stack<string> stack = new Stack<string>();
            foreach (char c in s)
            {
                if (parentheses.Keys.Contains(c.ToString()))
                {
                    stack.Push(c.ToString());
                }

                if (parentheses.Values.Contains(c.ToString()))
                {
                    if (stack == null || stack.Count() == 0) return false;
                    var lastOpen = stack.Peek();
                    if (lastOpen != null)
                    {
                        if (c.ToString() == parentheses[lastOpen])
                        {
                            stack.Pop();
                        }
                        else return false;
                    }
                    else return false;
                }
            }

            if (stack.Count() == 0) return true;
            else return false;
        }


    }
}
