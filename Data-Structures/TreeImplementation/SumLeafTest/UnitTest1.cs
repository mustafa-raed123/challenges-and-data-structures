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
            tree.Root.Right = new TNode(3);
            tree.Root.Right.Left = new TNode(4);
            tree.Root.Right.Right = new TNode(5);
            tree.Root.Left = new TNode(2);
            tree.Root.Left.Right = new TNode(6);
            tree.Root.Left.Left = new TNode(1);
            


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
            tree.Root.Right = new TNode(-3);
            tree.Root.Right.Left = new TNode(-4);
            tree.Root.Right.Right = new TNode(-5);
            tree.Root.Left = new TNode(-2);
            tree.Root.Left.Right = new TNode(-6);
            tree.Root.Left.Left = new TNode(-1);

            // Act
            int result = tree.LeafSum();

            // Assert
            Assert.Equal(-16, result); 
        }
    }
}