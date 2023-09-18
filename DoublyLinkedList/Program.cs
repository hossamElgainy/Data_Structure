using System;

namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new();
            int Value;
            while (true)
            {
                Console.WriteLine("Enter 1 To Insert At First");
                Console.WriteLine("Enter 2 To Insert At Last");
                Console.WriteLine("Enter 3 To Insert At Postion");
                Console.WriteLine("Enter 4 To Delete From First");
                Console.WriteLine("Enter 5 To Delete From Last");
                Console.WriteLine("Enter 6 To Delete An Element");
                Console.WriteLine("Enter 7 To Get The Length");
                Console.WriteLine("Enter 8 To Get The Reverse The List");
                Console.WriteLine("Enter 9 To Search For An Element");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case (1):
                        Console.Write("Enter The Value: ");
                        Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        list.InsertAtFirst(Value);
                        list.Print();
                        break;
                    case (2):
                        Console.Write("Enter The Value: ");
                        Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        list.InsertAtLast(Value);
                        list.Print();
                        break;
                    case (3):
                        Console.Write("Enter The Value: ");
                        Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        Console.Write("Enter The Postion: ");
                        int Position = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        list.InsertAtPos(Position, Value);
                        list.Print();
                        break;
                    case (4):
                        list.RemoveFirst();
                        list.Print();
                        break;
                    case (5):
                        list.RemoveLast();
                        list.Print();
                        break;
                    case (6):
                        Console.Write("Enter The Value: ");
                        Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        list.RemoveElement(Value);
                        list.Print();
                        break;
                    case (7):
                        Console.WriteLine($"The Length Is: {list.length}");
                        break;
                    case (8):
                        Console.WriteLine("The List Before Reverse Is:");
                        list.Print();
                        list.ReverseList();
                        list.Print();
                        break;
                    case (9):
                        Console.Write("Enter The Value: ");
                        Value = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        list.Search(Value);
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
