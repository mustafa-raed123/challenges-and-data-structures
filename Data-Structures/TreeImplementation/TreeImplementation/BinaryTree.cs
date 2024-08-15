using System.Text;
using System.Xml.Linq;
using TreeImplementation;

public class BinaryTree : BinarySearchTree
{
    private StringBuilder _output;
    public BinaryTree(int data, StringBuilder output = null) : base(data)
    {
        _output = output;
    }



    public void Pre_Order(TNode node)
    {
        if (node == null) return;

        Print(node.data, ConsoleColor.Green, "->");
        Pre_Order(node.left);
        Pre_Order(node.right);
    }

    public void In_Order(TNode node)
    {
        if (node == null) return;

        In_Order(node.left);
        Print(node.data, ConsoleColor.Green, "->");
        In_Order(node.right);
    }

    public void Post_Order(TNode node)
    {
        if (node == null) return;

        Post_Order(node.left);
        Post_Order(node.right);
        Print(node.data, ConsoleColor.Green, "->");
    }

    public string Print(int data, ConsoleColor color =
        ConsoleColor.White, string delimiter = "-->")
    {
        string output = $"{data}{delimiter}";

        if (_output != null)
        {
            _output.Append(output);
        }
        else
        {
            Console.ForegroundColor = color;
            Console.Write(output);
            Console.ResetColor();
        }
            return output;

    }
    public void Mirror()
    {
        MirrorHelper(Root);
    }

    private void MirrorHelper(TNode node)
    {
        if (node == null)
        {
            return;
        }     
        MirrorHelper(node.left);
        MirrorHelper(node.right);     
        TNode temp = node.left;
        node.left = node.right;
        node.right = temp;
    }
}