using Stack_Queue.Stack.ReverseStackUsingQueue;

namespace ReverseStackTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseStackWithmultipleElement()
        {
            StackWithReverse stackWithReverse = new StackWithReverse();
            stackWithReverse.Push(1);
            stackWithReverse.Push(2);
            stackWithReverse.Push(3);
            stackWithReverse.Push(4);
            stackWithReverse.Push(5);
            stackWithReverse.ReverseStack();
            Assert.Equal(1, stackWithReverse.Pop());

        }
        [Fact]
        public void ReverseStackWithOneElement()
        {
            StackWithReverse stackWithReverse = new StackWithReverse();

            stackWithReverse.Push(5);
            stackWithReverse.ReverseStack();
            Assert.Equal(5, stackWithReverse.Pop());

        }
        [Fact]
        public void ReverseStackWithEmptyElement()
        {
            StackWithReverse stackWithReverse = new StackWithReverse();
            

  
            var exception = Assert.Throws<Exception>(() => stackWithReverse.Peek());
            Assert.Equal("The Stack is Empty", exception.Message);

        }
    }
}