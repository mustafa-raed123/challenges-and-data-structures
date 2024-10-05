using TreeImplementation;

namespace MaxLevelTest
{
    public class UnitTest1
    {
        [Fact]
        public void LargestValueEachLevel_SumOfLargestValues_IsCorrect()
        {
            // Arrange
            var binaryTree = new BinaryTree(10);
            binaryTree.Root.Left = new TNode(7);
            binaryTree.Root.Right = new TNode(15);
            binaryTree.Root.Left.Left = new TNode(5);
            binaryTree.Root.Left.Right = new TNode(9);
            binaryTree.Root.Right.Left = new TNode(11);
            binaryTree.Root.Right.Right = new TNode(20);

            // Act
            var largestValues = binaryTree.LargestValueEachLevel();
            int actualSum = 0;
            foreach (int value in largestValues)
            {
                actualSum += value;
            }

            // Assert
            int expectedSum = 45;
            Assert.Equal(expectedSum, actualSum);
        }
    }
}