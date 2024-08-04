using Stack_Queue.Stack.Delete_Milddle_Element_Stack;
namespace RemoveMiddleElementTest
{
    public class UnitTest1
    {
        
            [Fact]
            public void RemoveMiddleElementAnOddSized()
            {
                // Arrange
                var stack = new StackWithDeleteMiddle();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                stack.Push(5); 

                // Act
                stack.DeleteMiddle();

                // Assert
                var expected = new List<int> { 5, 4, 2, 1 };
                var actual = new List<int>();
                var node = stack.top;

                while (node != null)
                {
                    actual.Add(node.Data);
                    node = node.Next;
                }

                Assert.Equal(expected, actual);
            }

        [Fact]
        public void RemoveMiddleElementAnEvenSized()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4); // Stack is now [4, 3, 2, 1], middle is 3

            // Act
            stack.DeleteMiddle();

            // Assert
            var expected = new List<int> { 4, 2, 1 }; 
            var actual = new List<int>();
            var node = stack.top;

            while (node != null)
            {
                actual.Add(node.Data);
                node = node.Next;
            }

            Assert.Equal(expected, actual);
        }
    }
}