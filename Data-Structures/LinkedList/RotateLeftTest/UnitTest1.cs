using LinkedList;

namespace RotateLeftTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestRotatingByZero()
        {
            // Arrange
            LinkedLists list = new LinkedLists();
            list.InsertToTail(1);
            list.InsertToTail(2);
            list.InsertToTail(3);
            list.InsertToTail(4);
            list.InsertToTail(5);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal(1, list.head.data);
            Assert.Equal(2, list.head.next.data);
            Assert.Equal(3, list.head.next.next.data);
            Assert.Equal(4, list.head.next.next.next.data);
            Assert.Equal(5, list.head.next.next.next.next.data);
        }


        [Fact]
        public void TestRotatingByValueGreaterThanListLength()
        {
            // Arrange
            LinkedLists list = new LinkedLists();
            list.InsertToTail(1);
            list.InsertToTail(2);
            list.InsertToTail(3);
            list.InsertToTail(4);
            list.InsertToTail(5);

            // Act
            list.RotateLeft(7);

            // Assert
            Assert.Equal(1, list.head.data);
            Assert.Equal(2, list.head.next.data);
            Assert.Equal(3, list.head.next.next.data);
            Assert.Equal(4, list.head.next.next.next.data);
            Assert.Equal(5, list.head.next.next.next.next.data);
        }
    }
}