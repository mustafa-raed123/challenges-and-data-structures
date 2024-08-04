using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue.Stack.Delete_Milddle_Element_Stack
{
    public  class StackWithDeleteMiddle : stack
    {
        public void DeleteMiddle()
        {
            stack NewStack = new stack();
            if (IsEmpty()) return;
            int count = 0;
            Node node = top;           
            while (node != null) 
            {
                count++;
                node = node.Next;
            }      
            int middle = count % 2 == 0 ? (count / 2) - 1 : (count / 2);
            count = 0;
            node = top;
                                
            while (node != null) 
            {
                if (count != middle)
                {
                    NewStack.Push(node.Data);
                }
                node = node.Next;
                count++;
            }     
            top = null;
            Node newNode = NewStack.top;
            while (newNode != null)
            {
                Push(newNode.Data);
                newNode = newNode.Next;
            }
        }
    }
}
