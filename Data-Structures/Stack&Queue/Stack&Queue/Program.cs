using Stack_Queue.Stack;

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
            Console.WriteLine(stack1.Peek() == 4) ;

            Console.Write("\t\tThe Stack Items ==>");
            stack1.Print();
            stack1.Pop();
            Console.WriteLine("\t\t\tAfter Using Pop Method() ");
            Console.WriteLine();
            Console.Write("\t\tThe Stack Items ==>");


            stack1.Print();

            Queue.Queue queue = new Queue.Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine(stack1.Peek() == 4);

            Console.Write("\t\tThe Queue Items ==>");
            queue.Print();
            queue.Dequeue();          
            Console.WriteLine("\t\t\tAfter Using Dequeue Method() ");
            Console.WriteLine();        
            Console.Write("\t\tThe Queue Items ==>");
            queue.Print();



        }
    }
}
