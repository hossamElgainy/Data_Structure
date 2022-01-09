using System.Collections.Generic;

namespace DataStructure
{
    public class balancedParencess
    {
        bool ArePair(char open,char close)
        {
            if (open == '(' && close == ')')
                return true;
            else if (open == '[' && close == ']')
                return true;
            else if (open == '{' && close == '}')
                return true;
            else
                return false;
        }
        public bool AreBalanced(string exp)
        {
            Stack<char> myStack = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
                    myStack.Push(exp[i]);
                else if (exp[i] == ')' || exp[i] == ']' || exp[i] == '}')
                {
                    if (myStack.Count == 0 || !ArePair(myStack.Peek(), exp[i]))
                        return false;
                    myStack.Pop();
                }
            }
            if (myStack.Count == 0) 
                return true;
            return false;
        }
    }
}
