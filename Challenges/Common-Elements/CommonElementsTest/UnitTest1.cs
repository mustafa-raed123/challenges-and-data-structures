using Common_Elements;

namespace CommonElementsTest
{
    public class UnitTest1
    {


        [Fact]        
        public void CommonElements()
        {
            //Arrange
            int[] arr1 = new int[] { 1, 2, 3, 0 };
            int[] arr2 = new int[] {2, 3, 4, 9};
            int[] arr3 = new int[] {79, 8, 15 };
            int[] arr4 = new int[] { 23, 79, 8 };

            //Act
            List<int> link1 = Program.CommonElements(arr1, arr2);
            List<int> link2 = Program.CommonElements(arr3, arr4);
            //Assert
            Assert.Equal(2, link1.Count);
            Assert.Equal(2, link2.Count);
        }
    }
}