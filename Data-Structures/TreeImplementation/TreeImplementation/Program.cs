using System.Xml.Linq;

namespace TreeImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {

            //BinarySearchTree binarySearchTree = new BinarySearchTree(3);
            // binarySearchTree.Insert(8);
            // binarySearchTree.Insert(2);
            // binarySearchTree.Insert(1);
            // binarySearchTree.Insert(5);
            // binarySearchTree.Insert(7);
            // Console.WriteLine("Pre-Order-Traversal");
            // binarySearchTree.Pre_Order(binarySearchTree.Root);

            // Console.WriteLine();
            // Console.WriteLine("In-Order-Traversal");

            // binarySearchTree.In_Order(binarySearchTree.Root);
            // Console.WriteLine();
            // Console.WriteLine("Post-Order-Traversal");
            // Console.WriteLine("Remove 8");

            // binarySearchTree.Remove(8);

            // binarySearchTree.Post_Order(binarySearchTree.Root);
            // var node = binarySearchTree.Search(binarySearchTree.Root, 6);

            // Console.WriteLine();
            // Console.WriteLine("Does the number 6 exist?");


            // Console.WriteLine();
            // if (node != null)
            // {

            //     Console.WriteLine($"The number {node.data} exists.");
            // }
            // else
            // {
            //     Console.WriteLine($"The Number Not Exist");
            // }
            //BinarySearchTree Btree = new BinarySearchTree(4);

            //// Insert additional values into the BinarySearchTree
            //Btree.Insert(8);
            //Btree.Insert(7);
            //Btree.Insert(12);
            //Btree.Insert(9);
            //Btree.Insert(10);
            //Btree.Insert(13);
            //Btree.Insert(15);
            //Btree.Insert(16);
            //Btree.Insert(17);

            //// Perform tree traversals
            //Console.WriteLine("Pre-Order Traversal:");
            //Btree.Pre_Order(Btree.Root);
            Console.WriteLine();

            // Find and display the second maximum value
            //try
            //{
            //    Console.WriteLine("The Second Max Value is:");
            //    int? secondMax = Btree.SecondMax(Btree.Root);
            //    Console.WriteLine(secondMax.HasValue ? secondMax.ToString() : "Not found");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            //Btree.In_Order(Btree.Root);
            //Btree.Mirror();
            //Console.WriteLine();
            //Console.WriteLine("Arter Using Mirror method");

            //Console.WriteLine();
            //Btree.In_Order(Btree.Root);
            //BinaryTree Btree = new BinaryTree(4);


            //Btree.Root = new TNode(9);
            //Btree.Root.left = new TNode(8);
            //Btree.Root.right = new TNode(12);
            //Btree.Root.left.left = new TNode(3);
            //Btree.Root.left.right = new TNode(7);
            //Btree.Root.right.left = new TNode(17);
            //Btree.Root.right.right = new TNode(23);
            //Btree.Root.left.left.right = new TNode(4);


            //Console.WriteLine("Pre-Order Traversal:");
            //Btree.Pre_Order(Btree.Root);
            //Console.WriteLine();


            //int leafSum = Btree.LeafSum();
            //Console.WriteLine("The sum of all leaf nodes is:");
            //Console.WriteLine(leafSum);
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);
            Btree.Root.Right.Right.Right = new TNode(10);
            Btree.Root.Right.Right.Right.Right = new TNode(10);
        //    Btree.Root.Left.Right.Right = new TNode(19);
            // Btree.Root.Left.Left.Left = new TNode(7);


            //   int maxLevel = Btree.FindMaxLevelNodes();
            int minDepth = Btree.MinDepth(Btree.Root);
            Console.WriteLine("the Min Depth Nodes : " + minDepth);
        }
    }
}
