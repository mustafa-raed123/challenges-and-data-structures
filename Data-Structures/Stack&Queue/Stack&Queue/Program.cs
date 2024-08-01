using Stack_Queue.Stack;
using Stack_Queue.Queue;
using Stack_Queue.Stack.ReverseStackUsingQueue;
namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            stack stack1 = new stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            Console.Write("\t\tThe Stack Items ==>");
            stack1.Print();
            //stack1.Pop();
            Console.WriteLine("\t\t\tAfter reverse stack ");
            Console.WriteLine();
            Console.Write("\t\tThe Stack Items ==>");
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);
            stackWithReverse.Push(2);
            stackWithReverse.Push(3);
            stackWithReverse.Push(4);
            stackWithReverse.Push(5);
            stackWithReverse.ReverseStack();
            stackWithReverse.Push(6);
            stackWithReverse.Push(7);
            stackWithReverse.ReverseStack();


            stackWithReverse.Print();

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
