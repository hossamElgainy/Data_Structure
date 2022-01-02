using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stack
    {
        private int top;
        int[] item=new int[100];

        public Stack()
        {
            top = -1;
        }
        public void Push(int Element)
        {
            if (top > 99)
            {
                Console.WriteLine("The Stack Is Full");
            }
            else
            {
                top++;
                item[top] = Element;
            }
            
        }
        public void Pop()
        {
            if (top < 0)
                Console.WriteLine("The stack Is Empty");            
            else
                top--;
        }
        public void GetTop()
        {
            if (top < 0)
                Console.WriteLine("The stack Is Empty");
            else
                Console.WriteLine(item[top]);
        }
        public void Print()
        {
            Console.Write("Stack Is [ ");
            for (int i = top; i >-1; i--)
            {
                Console.Write(item[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
