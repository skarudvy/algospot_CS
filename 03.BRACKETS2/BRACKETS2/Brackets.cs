using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRACKETS2
{
    public class Brackets
    {
        private string bracket_list = "";
        Stack<char> st = new Stack<char>();

        public Brackets(string bracket_list)
        {
            this.bracket_list = bracket_list;
        }

        private bool isStartBracket(char bracket)
        {
            if (bracket == '(' || bracket == '{' || bracket == '[')
                return true;
            else
                return false;
        }

        private bool isMatchBracket(char start, char end)
        {
            if (start == '(' && end == ')')
                return true;
            else if (start == '{' && end == '}')
                return true;
            else if (start == '[' && end == ']')
                return true;
            else
                return false;
        }

        public bool ValidationBracket()
        {
            int length = bracket_list.Length;
            if (length % 2 != 0)
                return false;

            for (int bracket_index = 0; bracket_index < length; bracket_index++)
            {
                if (isStartBracket(bracket_list[bracket_index]))
                {
                    st.Push(bracket_list[bracket_index]);
                }
                else
                {
                    if (st.Count != 0 && isMatchBracket(st.Peek(), bracket_list[bracket_index]))
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
