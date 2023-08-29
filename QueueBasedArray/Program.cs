using DataStructure;
using System;

namespace QueueBasedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingArray queue = new();
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(11);
            queue.PrintQueue();
            queue.DeQueue();
            queue.PrintQueue();
            Console.WriteLine($"Front IS: " + queue.GetFront());
            Console.WriteLine($"Rear Is: " + queue.GetRear());
            Console.ReadKey();
        }
    }
}
