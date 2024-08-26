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
            binaryTree.Root.left = new TNode(7);
            binaryTree.Root.right = new TNode(15);
            binaryTree.Root.left.left = new TNode(5);
            binaryTree.Root.left.right = new TNode(9);
            binaryTree.Root.right.left = new TNode(11);
            binaryTree.Root.right.right = new TNode(20);

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