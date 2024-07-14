
using LinkedList;
using System.Collections.Generic;
namespace RemoveDuplicateTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 6 }, new int[] { 1, 2, 3, 6 })]
        [InlineData(new int[] { 1, 2, 3, 3, 6, 6, 7 }, new int[] { 1, 2, 3, 6, 7 })]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1 }, new int[] { 1 })]
        public void RemoveDublicateTests(int[] input, int[] expected)
        {
            // Arrange
            LinkedLists linklist = new LinkedLists();
            foreach (var value in input)
            {
                linklist.InsertToTail(value);
            }

            // Act
            linklist.RemoveDublicate();
            Node current = linklist.head;
            List<int> actual = new List<int>();
            while (current != null)
            {
                actual.Add(current.Data);
                current = current.Next;
            }

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}