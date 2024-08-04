using Stack_Queue.Queue;

namespace Stack_Queue.Stack.ReverseStackUsingQueue
{
    public class StackWithReverse : stack
    {
        queue newqueue = new queue();


        public void ReverseStack()
        {
            if (IsEmpty()) return;

            while (!IsEmpty())
            {
                int PopStack = Pop();
                newqueue.Enqueue(PopStack);
            }
            while (!newqueue.IsEmpty())
            {
                int Dequeue = newqueue.Dequeue();
                Push(Dequeue);
            }
        
        }
    }
}
