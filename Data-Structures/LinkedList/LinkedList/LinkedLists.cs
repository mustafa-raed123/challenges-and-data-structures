﻿using System;
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
            
            Console.Write("\t\tHead ----> ");
            Node nn = head;
            while (nn != null)
            {
                if (nn != tail)
                {
                    Console.Write($"{nn.Data} --> ");
                    
                }
                else
                    Console.Write(nn.Data);
                nn = nn.Next;

            }
            Console.WriteLine("null");
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
        public void MergeSortedLists(LinkedLists linkedlist)
        {
            count = 0;
            if (linkedlist == null && head == null) return;
            LinkedLists newlinkedList = new LinkedLists();
            sortLinkedList();
            linkedlist.sortLinkedList(); //method To sort a linkedlist from smallest to largest 
            Node current1 = head;
            Node current2 = linkedlist.head;
            while (current1 != null || current2 != null) {
                if (current1 != null && (current2 == null || current1.Data <= current2.Data))
                {                   
                    {
                        newlinkedList.InsertToTail(current1.Data);
                        count++;
                        current1 = current1.Next;
                    }                  
                }            
               else if (current2 != null)
                {
                    newlinkedList.InsertToTail(current2.Data);
                    count++;
                    current2 = current2.Next;
                }
            }
            head= newlinkedList.head;          
        }

        public void sortLinkedList()
        {
            List<int> list = new List<int>();
            if (head == null) return;
            while(head != null)
            {
                list.Add(head.Data);
                head = head.Next;
            }
            head = null;
            tail = null;              
            foreach (var item in list.OrderBy(n => n).ToList())
            {
                InsertToTail(item);
            }

        }
       
    }

}

