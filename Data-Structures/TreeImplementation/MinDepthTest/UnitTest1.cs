using TreeImplementation;

namespace MinDepthTest
{
    public class UnitTest1
    {
        // Test for an empty tree
        [Fact]
        public void Test_EmptyTree_ReturnsZero()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root = null;
            var root = Btree.Root;


            int result = Btree.MinDepth(root);

            Assert.Equal(0, result);
        }

        // Test for a tree with varying depths
        [Fact]
        public void Test_MultipleNodesWithVaryingDepths()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);

            int result = Btree.MinDepth(Btree.Root);
 
            Assert.Equal(2, result);
        }

        // Another test for a tree with greater depths
        [Fact]
        public void Test_MultipleNodesWithDeeperDepths()
        {
            BinaryTree Btree = new BinaryTree(1);

            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Left.Right.Right = new TNode(6);
            int result = Btree.MinDepth(Btree.Root);
            Assert.Equal(2, result);
        }
    }
}