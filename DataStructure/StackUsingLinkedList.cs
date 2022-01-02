using System;
namespace DataStructure
{
    public class StackUsingLinkedList
    {
        private class Node
        {
            public int data;
            public Node link;
        }
        Node Top;
        public StackUsingLinkedList()
        {
            this.Top = null;
        }
        public void Push(int Element)
        {
            Node temp = new Node();
            temp.data = Element;
            temp.link = Top;
            Top = temp;
        }
        public bool IsEmpty()
        {
            return Top == null;
        }
        public int GetTop()
        {
            if (!IsEmpty())
            {
                return Top.data;
            }
            else
            {
                System.Console.WriteLine("The Stack Is Empty");
                return -1;
            }
        }
        public void Pop()
        {
            if (IsEmpty())
            {
                System.Console.WriteLine("The Stack Is Empty");
            }
            else
            {
                Top = (Top).link;
            }
        }
        public void display()
        {
            // check for stack underflow
            if (Top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = Top;
                Console.Write("[");
                while (temp != null)
                {

                    // print node data
                    Console.Write(temp.data+" ");

                    // assign temp link to temp
                    temp = temp.link;
                }
                Console.WriteLine("]");
            }
        }
    }
}
