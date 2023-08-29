using DataStructure;
using System;

namespace StackBasedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack Implementation
            Stack s = new();
            // Push On The Stack
            s.Push(5);
            s.Push(10);
            s.Push(15);
            s.Push(20);

            //Print The Stack Elements
            s.Print();

            // Get The Top Element On The Stack
            s.GetTop();

            //Delete An Element From The Stack
            s.Pop();

            // Push On The Stack
            s.Push(7);

            //Print The Stack Elements
            s.Print();

            // Get The Top Element On The Stack
            s.GetTop();
            Console.ReadKey();
        }
    }
}
