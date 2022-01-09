using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Stack Implementation
            Stack s = new Stack();
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
            s.GetTop();*/

            /*StackUsingLinkedList s = new StackUsingLinkedList();
            s.Push(10);
            s.Push(15);
            s.Push(20);
            s.Push(25);
            s.display();
            s.Pop();
            s.display();*/
            balancedParencess b = new balancedParencess();
            
            Console.Write("Enter An Expression:");
            string Expression = Console.ReadLine();
            if(b.AreBalanced(Expression))
                Console.WriteLine("Balanced");
            else
                Console.WriteLine("Not Balanced");
        }
    }
}
