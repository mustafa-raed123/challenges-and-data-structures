using System;
using System.Xml.Linq;
using TreeImplementation;
using Xunit;

namespace MaxLevelNodesTest
{
    // Assuming your Node and BinaryTree classes are inside your main project and properly referenced
    public class MaxLevelNodesTests
    {
        // Test with distinct number of nodes at each level
        [Fact]
        public void FindMaxLevelNodes_ShouldReturnLevelWithMaximumNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); 
        }


        [Fact]
        public void FindMaxLevelNodes_MultipleLevelsWithSameMaxNodes_ShouldReturnSmallestLevel()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Left = new TNode(6);
            Btree.Root.Right.Right = new TNode(7);

            // Act
            int result = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, result); // Level 2 has the most nodes
        }
    }
}
