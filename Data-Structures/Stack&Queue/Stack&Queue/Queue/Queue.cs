using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Stack_Queue.Queue
{
    public class queue
    {
        private Node first { get; set; }
        private Node last { get; set; }
        public queue()
        {
            first = last = null!;
        }

        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (IsEmpty()) last = first = newnode;
            else
            {
                last.Next = newnode;
                last = newnode;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is Empty");            
            else
            {
                int data = first.Data;
                first = first.Next;
                return data; 
            }
        }
        public int Peek()
        {
            if(IsEmpty()) throw new Exception("Queue is Empty");
            return first.Data;
        }
        public bool IsEmpty() => (first == null);  
        public void Print()
        {
            Node node = first;
            while (node != null)
            {
                Console.Write($"[{node.Data}] -> ");
                node = node.Next;
            }           
        }
    }
}