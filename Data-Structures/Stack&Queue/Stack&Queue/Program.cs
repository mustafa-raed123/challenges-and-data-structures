using Stack_Queue.Stack;
using Stack_Queue.Queue;
using Stack_Queue.Stack.ReverseStackUsingQueue;
using Stack_Queue.Stack.Delete_Milddle_Element_Stack;
namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //stack stack1 = new stack();
            //stack1.Push(1);
            //stack1.Push(2);
            //stack1.Push(3);
            //stack1.Push(4);
            //Console.Write("\t\tThe Stack Items ==>");
            //stack1.Print();
            ////stack1.Pop();
            //Console.WriteLine("\t\t\tAfter reverse stack ");
            //Console.WriteLine();
            //Console.Write("\t\tThe Stack Items ==>");
            //StackWithReverse stackWithReverse = new StackWithReverse();
            //stackWithReverse.Push(1);
            //stackWithReverse.Push(2);
            //stackWithReverse.Push(3);
            //stackWithReverse.Push(4);
            //stackWithReverse.Push(5);
            //stackWithReverse.ReverseStack();
            //stackWithReverse.Push(6);
            //stackWithReverse.Push(7);
            //stackWithReverse.ReverseStack();


            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            stack.Print(); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            stack.DeleteMiddle();
            Console.WriteLine("After deleting middle element");
            stack.Print(); // Stack: Top -> 5 -> 8 -> 14 -> 7
            stack.Push(2);
            stack.Push(9);
            stack.Push(11);
            stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            Console.WriteLine("After deleting middle element");

            stack.DeleteMiddle();
            stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7



            //stackWithReverse.Print();

            //queue queue = new queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine(stack1.Peek() == 4);

            //Console.Write("\t\tThe Queue Items ==>");
            //queue.Print();
            //queue.Dequeue();          
            //Console.WriteLine("\t\t\tAfter Using Dequeue Method() ");
            //Console.WriteLine();        
            //Console.Write("\t\tThe Queue Items ==>");
            //queue.Print();



        }
    }
}
