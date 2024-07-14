using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedLists
    {
        public Node head;
        public Node tail;
        public int count;
        public LinkedLists()
        {
            head = null;
            tail = null;
            count = 0;

        }
        public void InsertToHead(int data)
        {
            if (head == null)
            {
                head = new Node();
                head.Data = data;
                head.Next = null;
                tail = head;
                count++;


            }
            else
            {
                Node NewNode = new Node();
                NewNode.Data = data;
                NewNode.Next = head;
                head = NewNode;
                count++;
            }
        }
        public void InsertToTail(int data)
        {
            if (tail == null)
                InsertToHead(data);
            else
            {
                Node NewNode = new Node();
                NewNode.Data = data;
                tail.Next = NewNode;
                tail = NewNode;
                count++;
            }
        }
        public void DeleteFromTail()
        {
            if (tail == null) return;
          
            
             Node NewNode = head;
             while (NewNode.Next != tail)
             {
                 NewNode = NewNode.Next;
             }
            tail = NewNode;
            NewNode.Next = null;
            count--;
        }
        public bool Includes(int data)
        {
            if (head == null) return false;
   
             Node node = head;
            while (node != null)
               {
                  if (node.Data == data) return true;
                   node = node.Next;
                }         
            return false;
        }
        public void Remove(int data)
        {
            if (head == null) return;
            if (head.Data == data)
                head = head.Next;
            if (tail.Data == data) DeleteFromTail();
            Node node = head;
            while (node != null)
            {
                if (node.Next == null) return;

                else if (node.Next.Data == data)

                    node.Next = node.Next.Next;

                node = node.Next;
            }
        }
        public void PrintList()
        {
            Console.Write("\t\t\t\tHead ----> ");
            Node nn = head;
            while (nn != null)
            {
                if (nn != tail)
                    Console.Write($"{nn.Data} --> ");
                else 
                    Console.Write(nn.Data);
                nn = nn.Next;

            }
            Console.WriteLine("---> null");
        }
        public void RemoveDublicate()
        {
            if (head == null) return;
            Node current = head;
            while (current.Next != null)
            {
                if (current.Data == current.Next.Data)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }

            }

        }
    }
}
