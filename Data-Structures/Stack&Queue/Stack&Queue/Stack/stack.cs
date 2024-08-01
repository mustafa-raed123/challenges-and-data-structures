using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue.Stack
{
    public class stack
    {
        private Node top;

        public stack()
        {
            top = null!;
        }
        public int Push(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = top;
            top = newnode;
            return data;
        }
        public int Pop()
        {
            if (IsEmpty()) throw new Exception(" THe Stack is Empty ");           
            int data = top.Data;
            top = top.Next;
            return data;
        }
        public int Peek()
        {
           if (IsEmpty()) throw new Exception("The Stack is Empty");   
            return top.Data;
        }
        public bool IsEmpty()=> top == null;
        public void Print()
        {
            Node node = top;
            while (node != null)
            {
                Console.Write($"[{node.Data}] -> ");
                node = node.Next;
            }
            Console.WriteLine("null");
            Console.WriteLine();
        }
    }
}
