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
            Assert.Equal(1, list.head.Data);
            Assert.Equal(2, list.head.Next.Data);
            Assert.Equal(3, list.head.Next.Next.Data);
            Assert.Equal(4, list.head.Next.Next.Next.Data);
            Assert.Equal(5, list.head.Next.Next.Next.Next.Data);
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
            Assert.Equal(1, list.head.Data);
            Assert.Equal(2, list.head.Next.Data);
            Assert.Equal(3, list.head.Next.Next.Data);
            Assert.Equal(4, list.head.Next.Next.Next.Data);
            Assert.Equal(5, list.head.Next.Next.Next.Next.Data);
        }
    }
}