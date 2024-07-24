using Stack_Queue.Stack;
using Stack_Queue.Queue;

namespace Stack_QueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestStackImplementation()
        {
            stack stack = new stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Assert.Equal(3, stack.Peek());
            Assert.Equal(3,stack.Pop());

            Assert.Equal(2,stack.Peek() );
            stack.Pop();
            stack.Pop();
            Assert.True(stack.ISEmpty());
        }
        [Fact]
        public void TestQueueImplementation()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.Equal(1, queue.Peek());
            Assert.Equal(1, queue.Dequeue());

            Assert.Equal(2, queue.Peek());
            queue.Dequeue();
            queue.Dequeue();
            Assert.True(queue.IsEmpty());
        }
    }
}