using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class LinkedList
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
                head = tail = newNode;
                newNode.next = newNode.prev = null;
            }else
            {
                newNode.next = head;
                newNode.prev = null;
                head.prev = newNode;
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
                newNode.next = newNode.prev = null;
            }
            else
            {
                newNode.next = null;
                newNode.prev = tail;
                tail.next = newNode;
                tail = newNode;
            }
            length++;
        }
        public void InsertAtPos(int pos,int item)
        {
            if(pos<0 || pos > length)
            {
                Console.WriteLine("Out Of Range...");
            }
            else
            {
                Node newNode = new();
                newNode.item = item;
                if (pos == 0)
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
                    for (int i = 1; i < pos; i++)
                        Curr = Curr.next;
                    newNode.next = Curr.next;
                    newNode.prev = Curr;
                    Curr.next = newNode;
                    Curr.next.prev = newNode;
                }
                length++;
            }
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
                head.prev = null;
                length--;
            }
        }
        public void RemoveLast()
        {
            if(length == 0)
                Console.WriteLine( "The List Is Empty");
            else if(length == 1)
                head = tail = null;
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            length--;
        }
        public void RemoveElement(int item)
        {

            if(length ==0)
                Console.WriteLine("The List Is Empty");
            Node curr, prev;
            if(head.item == item) //Remove First Element
            {
               RemoveFirst();
            }
            else
            {
                curr = head.next;
                while (curr != null)
                {
                    if (curr.item == item)
                        break;
                    curr = curr.next;
                }
                if(curr==null)
                    Console.WriteLine("The Item Not Found");
                else if(curr.next ==null)
                    RemoveLast();
                else
                {
                    curr.prev.next = curr.next;
                    curr.next.prev = curr.prev;
                    length--;
                }
            }
        }

        public void ReverseList()
        {
            Node prev, next, curr;
            prev = null;
            curr = head;
            next = curr.next;
            while(next != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public void Search(int element)
        {
            Node curr =head;
            int position = 1;
            while(curr != null)
            {
                if (curr.item == element)
                {
                    Console.WriteLine($"This Element Is Exist At Position: {position}");
                }                   
                curr = curr.next;
                position+=1;
            }
            Console.WriteLine("This Element Does Not Exist");
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
