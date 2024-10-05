
using LinkedList;
using System.Collections.Generic;
namespace RemoveDuplicateTest
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveDublicate()
        {
            //Arrange
            LinkedLists linkedLists = new LinkedLists();
            linkedLists.InsertToTail(2);
            linkedLists.InsertToTail(3);
            linkedLists.InsertToTail(2);
            linkedLists.InsertToTail(4);
            //act
            linkedLists.RemoveDublicates();
            //Assert
            Assert.Equal(2, linkedLists.head.data);
            Assert.Equal(3, linkedLists.head.next.data);
            Assert.Equal(4, linkedLists.head.next.next.data);
        }
        [Fact]
        public void AddFromPos()
        {
            // Arrange
             LinkedLists linkedLists1 = new LinkedLists();
            linkedLists1.InsertToTail(1);
            linkedLists1.InsertToTail(2);
            linkedLists1.InsertToTail(3);
            linkedLists1.InsertToTail(2);
            linkedLists1.InsertToTail(4);
            // Act
            linkedLists1.InserFromPos(10, 3);
            // Assert
            Assert.Equal(1, linkedLists1.head.data);
            Assert.Equal(2, linkedLists1.head.next.data);
            Assert.Equal(10, linkedLists1.head.next.next.data);
            Assert.Equal(3, linkedLists1.head.next.next.next.data);



        }
        [Fact]
        public void AddFromPosa()
        {
            // Arrange
            LinkedLists linkedLists1 = new LinkedLists();
           
            // Act
            linkedLists1.InserFromPos(10, 3);

            // Assert
            Assert.True(  linkedLists1.head.data == 0)
           ;



        }


    }
}