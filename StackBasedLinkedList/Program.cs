using DataStructure;
using System;

namespace StackBasedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList s = new();
            while (true)
            {
                Console.WriteLine("Enter 1 To Push");
                Console.WriteLine("Enter 2 To Pop");
                Console.WriteLine("Enter 3 To Get Top");
                Console.WriteLine("Enter 4 To Display\n");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case (1):
                        Console.Write("Enter The Value: ");
                        int Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(); ;
                        s.Push(Value);
                        break;
                    case (2):
                        s.Pop();
                        break;
                    case (3):
                        s.GetTop();
                        break;
                    case (4):
                        s.display();
                        break;
                    default:
                        Console.WriteLine("Enter A Valid Number");
                        break;
                }

            }

            Console.ReadKey();
        }
    }
}
