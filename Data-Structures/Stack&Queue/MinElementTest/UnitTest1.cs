using Stack_Queue.Stack.MinStack;

namespace MinElementTest
{
    public class UnitTest1
    {
        [Fact]
        public void minimumelemen()
        {
            // Arrange
            var stack = new MinStack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(6);
            stack.Push(1);

            // Act
            stack.GetMin();
            Assert.Equal(stack.GetMin(), 1);
            stack.Pop();
            Assert.Equal(stack.GetMin(), 3);
            
            stack.Push(2);
            Assert.Equal(stack.GetMin(), 2);

        }

    }
}