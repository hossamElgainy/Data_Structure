using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class LinkedList
    {
        Node head;
        Node tail;
        public int length = 0;
        public void InsertAtFirst(int item)
        {
            Node newNode = new();
            newNode.item = item;
            if (length == 0)
            {
                head = newNode;
                newNode.next = null;
            }else
            {
                newNode.next = head;
                head = newNode;
            }
            length++;
        }
        public void InsertAtLast(int item)
        {
            Node newNode = new();
            newNode.item = item;
            if(length == 0)
            {
                head = tail = newNode;
                newNode.next = null;
            }
            else
            {
                tail = head;
                while (tail.next != null)
                    tail = tail.next;
                tail.next = newNode;
                newNode.next = null;
                tail = newNode;
            }
            length++;
        }
        public void InsertAtPos(int pos,int item)
        {
            Node newNode = new();
            newNode.item = item;
            if(pos == 0)
            {
                InsertAtFirst(item);
            }
            else if (pos == length)
            {
                InsertAtLast(item);
            }
            else
            {
                Node Curr = head;
                for (int i = 1; i < pos-1; i++)
                    Curr = Curr.next;
                newNode.next = Curr.next;
                Curr.next = newNode;
            }
            length++;
        }
        public void RemoveFirst()
        {
            if (length ==0)
            {
                Console.WriteLine("The List Is Empty");
            }
            else if (length == 1)
            {
                head = tail = null;
                length--;
            }
            else
            {
                head = head.next;
                length--;
            }
        }
        public void RemoveLast()
        {
            Node curr = head.next;
            Node prev = head;
            while (curr != tail)
            {
                prev = curr;
                curr = curr.next;
            }
            prev.next = null;
            tail = prev;
            length--;
        }
        public void RemoveAtPos(int item)
        {

            if(length ==0)
                Console.WriteLine("The List Is Empty");
            Node curr, prev;
            if(head.item == item) //Remove First Element
            {
                head = head.next;
                length--;
                if (length == 0)
                    tail = null;
            }
            else
            {
                curr = head.next;
                prev = head;
                while (curr != null)
                {
                    if (curr.item == item)
                        break;
                    prev = curr;
                    curr = curr.next;
                }
                if(curr==null)
                    Console.WriteLine("The Item Not Found");
                else
                {
                    prev.next = curr.next;
                    if (tail == curr)
                        tail = prev;
                    length--;
                }
            }
        }



        public void Print()
        {
            Node curr = head;
            Console.Write("The List Is: ");
            while (curr != null)
            {
                Console.Write(curr.item + " ");
                curr = curr.next;
            }
            Console.WriteLine();
        }
    }
}
