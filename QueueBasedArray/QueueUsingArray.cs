using System;

namespace DataStructure
{
    public class QueueUsingArray
    {
        const int MAX_LENGTH = 100;
        private int rear;
        private int front;
        private int length;
        private int[] arr=new int[MAX_LENGTH];
        public QueueUsingArray()
        {
            front = 0;
            rear = MAX_LENGTH - 1;
            length = 0;
        }
        public bool IsEmpty()
        {
            if (length == 0)
                return true;
             return false;
        }
        public bool IsFull()
        {
            if (length == MAX_LENGTH)
                return true;
            return false;
        }
        public void Enqueue(int element)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Is Full...");
            }
            else
            {
                rear = (rear + 1) % MAX_LENGTH;
                arr[rear] = element;
                length += 1;
            }
        }
        public void DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Empty...");
            }
            else
            {
                front = (front + 1) % MAX_LENGTH;
                length -= 1;
            }
        }
        public int GetFront()
        {
            if(IsEmpty())
                Console.WriteLine("Queue Is Empty...");
            return arr[front];
        }
        public int GetRear()
        {
            if (IsFull())
                Console.WriteLine("Queue Is Full...");
            return arr[rear];
        }
        public void PrintQueue()
        {
            if (!IsEmpty())
            {
                Console.Write("Queue Is: ");
                for (int i = front; i != rear; i = (i + 1) % MAX_LENGTH)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine(arr[rear]);
            }
            else
            {
                Console.WriteLine("Queue Is Empty...");
            }

        }
    }
}
