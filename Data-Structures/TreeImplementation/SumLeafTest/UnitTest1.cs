using TreeImplementation;

namespace SumLeafTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLeafSumWithPositiveValues()
        {
            // Arrange
            var tree = new BinaryTree(3);
            tree.Root.right = new TNode(3);
            tree.Root.right.left = new TNode(4);
            tree.Root.right.right = new TNode(5);
            tree.Root.left = new TNode(2);
            tree.Root.left.right = new TNode(6);
            tree.Root.left.left = new TNode(1);
            


            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(16, result); 
        }

        [Fact]
        public void TestLeafSumWithNegativeValues()
        {
            // Arrange
            var tree = new BinaryTree(-3);
            tree.Root.right = new TNode(-3);
            tree.Root.right.left = new TNode(-4);
            tree.Root.right.right = new TNode(-5);
            tree.Root.left = new TNode(-2);
            tree.Root.left.right = new TNode(-6);
            tree.Root.left.left = new TNode(-1);

            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(-16, result); 
        }
    }
}