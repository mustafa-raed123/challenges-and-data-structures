using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeImplementation;

public class BinarySearchTree : BinaryTree
{
    public BinarySearchTree(int data) : base(data) { }

    public void Insert(int data) => Root = Insert(Root, data);

    private TNode Insert(TNode node, int data)
    {
        if (node == null) return new TNode(data);

        if (data < node.data)
        {
            node.Left = Insert(node.Left, data);
        }
        else if (data > node.data)
        {
            node.Right = Insert(node.Right, data);
        }

        return node;
    }

    public TNode Search(int data) => Search(Root, data);

    private TNode Search(TNode node, int data)
    {
        if (node == null || node.data == data)
            return node;

        if (data < node.data)
            return Search(node.Left, data);
        else
            return Search(node.Right, data);
    }

    public void Remove(int data) => Root = Remove(Root, data);

    private TNode Remove(TNode node, int data)
    {
        if (node == null) return null;

        if (data < node.data)
        {
            node.Left = Remove(node.Left, data);
        }
        else if (data > node.data)
        {
            node.Right = Remove(node.Right, data);
        }
        else
        {
            // Node with only one child or no child
            if (node.Left == null) return node.Right;
            if (node.Right == null) return node.Left;

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            TNode minNode = FindMin(node.Right);
            node.data = minNode.data;
            node.Right = Remove(node.Right, minNode.data);
        }

        return node;
    }

    private TNode FindMin(TNode node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

}
