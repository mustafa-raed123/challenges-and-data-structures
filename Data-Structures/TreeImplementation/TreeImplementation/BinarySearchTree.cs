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
            node.left = Insert(node.left, data);
        }
        else if (data > node.data)
        {
            node.right = Insert(node.right, data);
        }

        return node;
    }

    public TNode Search(int data) => Search(Root, data);

    private TNode Search(TNode node, int data)
    {
        if (node == null || node.data == data)
            return node;

        if (data < node.data)
            return Search(node.left, data);
        else
            return Search(node.right, data);
    }

    public void Remove(int data) => Root = Remove(Root, data);

    private TNode Remove(TNode node, int data)
    {
        if (node == null) return null;

        if (data < node.data)
        {
            node.left = Remove(node.left, data);
        }
        else if (data > node.data)
        {
            node.right = Remove(node.right, data);
        }
        else
        {
            // Node with only one child or no child
            if (node.left == null) return node.right;
            if (node.right == null) return node.left;

            // Node with two children: Get the inorder successor (smallest in the right subtree)
            TNode minNode = FindMin(node.right);
            node.data = minNode.data;
            node.right = Remove(node.right, minNode.data);
        }

        return node;
    }

    private TNode FindMin(TNode node)
    {
        while (node.left != null)
        {
            node = node.left;
        }

        return node;
    }
}
