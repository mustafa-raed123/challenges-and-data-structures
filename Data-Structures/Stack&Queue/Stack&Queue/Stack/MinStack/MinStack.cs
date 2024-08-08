using Stack_Queue.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue.Stack.MinStack
{
    public class MinStack : stack
    {
        public int GetMin()
        {
            if(IsEmpty())
            {
            throw new InvalidOperationException("An error occurred.");
            }
            var ListElement = new List<int>();  
            Node node = top;
            while (node != null)
            {
                ListElement.Add(node.Data);
                node = node.Next;
            }
            return ListElement.Min();
            
             
        }
    }
}
