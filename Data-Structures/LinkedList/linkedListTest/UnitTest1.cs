using LinkedList;
using System.Collections.Generic;
namespace linkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void DeleteFromTail()
        {
            LinkedLists linklist = new LinkedLists();
         
            linklist.InsertToTail(1);
            linklist.InsertToTail(2);
            linklist.InsertToTail(3);
            linklist.InsertToTail(6);
            linklist.InsertToTail(34);
            linklist.DeleteFromTail();
           

            Assert.Equal(6,linklist.tail.data );
            
        }
        [Fact]
        public void RemoveFromVal() { 
            LinkedLists linklist = new LinkedLists();

            linklist.InsertToTail(1);
            linklist.InsertToTail(2);
            linklist.InsertToTail(3);
            linklist.InsertToTail(6);
            linklist.InsertToTail(34);

            linklist.Remove(3);

            node current = linklist.head;
            Assert.Equal(1, current.data );
            Assert.Equal(2, current.next.data );
            Assert.Equal(6, current.next.next.data );
        }
        [Fact]
        public void PrintList()
        {
            LinkedLists linklist = new LinkedLists();
            linklist.InsertToTail(1);
            linklist.InsertToTail(2);
            linklist.InsertToTail(3);
            linklist.InsertToTail(34);
            linklist.InsertToTail(6);
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                linklist.PrintList();
                string expectedOutput = "\t\t\t\tHead ----> 1 --> 2 --> 3 --> 34 --> 6---> null" + Environment.NewLine;
                Assert.Equal(expectedOutput, sw.ToString());
            }

        }
    }
}