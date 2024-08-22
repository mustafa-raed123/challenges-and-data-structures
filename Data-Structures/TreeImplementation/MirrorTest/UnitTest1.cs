//  using System.Xml.Linq;
//using TreeImplementation;

//namespace MirrorTest
//{
//    public class UnitTest1
//    {
//        [Fact]
//        public void Test1()
//        {
//            BinaryTree Btree = new BinaryTree(4);

//            Btree.Root.left = new TNode(8);
//            Btree.Root.right = new TNode(7);
//            Btree.Root.left.left = new TNode(12);
//            Btree.Root.left.right = new TNode(9);
//            Btree.Mirror();
//            Assert.Equal(Btree.Root.left.data, 7);

//            Assert.Equal(Btree.Root.right.data, 8);

//            Assert.Equal(Btree.Root.right.right.data, 12);

//            Assert.Equal(Btree.Root.right.left.data, 9);

//        }
//    }
//}