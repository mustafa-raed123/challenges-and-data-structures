using System.Text;
using System.Xml.Linq;
using TreeImplementation;

namespace TreeImplementation
{
    public class BinaryTree
    {
        private StringBuilder _output;
        public TNode Root;

        public BinaryTree(int data, StringBuilder output = null)
        {
            _output = output;
            Root = new TNode(data);
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

        public string Print(int data, ConsoleColor color = ConsoleColor.White, string delimiter = "-->")
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

           
            TNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            
            MirrorHelper(node.left);
            MirrorHelper(node.right);
        }

        public int? SecondMax(TNode node)
        {
            if (node == null) throw new Exception("The node is null");

            int? max = null;
            int? secondmax = null;

            TraverseTree(node, ref max, ref secondmax);

            if (secondmax == null)
            {
                throw new InvalidOperationException("Second maximum value not found");
            }

            return secondmax;
        }

        private void TraverseTree(TNode node, ref int? max, ref int? secondmax)
        {
            if (node == null) return;

            TraverseTree(node.left, ref max, ref secondmax);

            if (max == null || node.data > max)
            {
                secondmax = max;
                max = node.data;
            }
            else if (node.data < max && (secondmax == null || node.data > secondmax))
            {
                secondmax = node.data;
            }

            TraverseTree(node.right, ref max, ref secondmax);
        }
        public int LeafSum()
        {
            if(Root == null) return 0;  
                return LeafSumHelper(Root);
            
        
        }       
        private int LeafSumHelper(TNode node)
        {
            if (node == null)
            {
                return 0;
            }

           
            if (node.left == null && node.right == null)
            {
                return node.data;
            }

            
            return LeafSumHelper(node.left) + LeafSumHelper(node.right);
        }
        public List<int> LargestValueEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode.data > maxAtLevel)
                    {
                        maxAtLevel = currentNode.data;
                    }

                    if (currentNode.left != null) queue.Enqueue(currentNode.left);
                    if (currentNode.right != null) queue.Enqueue(currentNode.right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }
    }
}
