using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(5);
            s.Push(10);
            s.Push(15);
            s.Push(20);
            s.Print();

            s.Pop();
            s.Push(7);
            s.Print();
        }
    }
}
