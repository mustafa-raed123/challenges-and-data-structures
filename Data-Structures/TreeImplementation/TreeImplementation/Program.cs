﻿using System.Xml.Linq;

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
            BinaryTree Btree = new BinaryTree(4);
            
            Btree.Root.left = new TNode(8);
            Btree.Root.right = new TNode(7);
            Btree.Root.left.left = new TNode(12);
            Btree.Root.left.right = new TNode(9);
            Console.WriteLine("InOrder - Treversal");
            Btree.In_Order(Btree.Root);
            Btree.Mirror();
            Console.WriteLine();
            Console.WriteLine("Arter Using Mirror method");

            Console.WriteLine();
            Btree.In_Order(Btree.Root);

        }
    }
}
