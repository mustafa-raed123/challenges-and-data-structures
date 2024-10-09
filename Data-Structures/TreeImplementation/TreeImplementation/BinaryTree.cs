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
            Pre_Order(node.Left);
            Pre_Order(node.Right);
        }

        public void In_Order(TNode node)
        {
            if (node == null) return;

            In_Order(node.Left);
            Print(node.data, ConsoleColor.Green, "->");
            In_Order(node.Right);
        }

        public void Post_Order(TNode node)
        {
            if (node == null) return;

            Post_Order(node.Left);
            Post_Order(node.Right);
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

           
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            
            MirrorHelper(node.Left);
            MirrorHelper(node.Right);
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

            TraverseTree(node.Left, ref max, ref secondmax);

            if (max == null || node.data > max)
            {
                secondmax = max;
                max = node.data;
            }
            else if (node.data < max && (secondmax == null || node.data > secondmax))
            {
                secondmax = node.data;
            }

            TraverseTree(node.Right, ref max, ref secondmax);
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

           
            if (node.Left == null && node.Right == null)
            {
                return node.data;
            }

            
            return LeafSumHelper(node.Left) + LeafSumHelper(node.Right);
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

                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }
        public void PrintRightView()
        {
            List<int> rightViewNodes = new List<int>();
            RightViewHelper(Root, 0, rightViewNodes);

            Console.WriteLine(string.Join(" ", rightViewNodes));
        }

        private void RightViewHelper(TNode node, int level,
            List<int> rightViewNodes)
        {
            if (node == null)
                return;
            if (level == rightViewNodes.Count)
                rightViewNodes.Add(node.data);
            RightViewHelper(node.Right, level + 1, rightViewNodes);
            RightViewHelper(node.Left, level + 1, rightViewNodes);
        }
        public int FindMaxLevelNodes()
        {
            if (Root == null)
                throw new Exception("Tree is empty");
            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);
            int level = 0;
            int maxNodes = 0;
            int maxLevel = 0;
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = level;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    TNode current = queue.Dequeue();

                    if (current.Left != null)                 
                        queue.Enqueue(current.Left);       
                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
                level++;
            }
            return maxLevel;
        }
        public int MinDepth(TNode Root)
        {
            if (Root == null) return 0;
            if (Root.Left == null && Root.Right == null)
                return 1;
            if (Root.Left != null && Root.Right == null)
                return 1 + MinDepth(Root.Left);
            if (Root.Left == null && Root.Right != null)
                return 1 + MinDepth(Root.Right);

            int leftNode = 1 + MinDepth(Root.Left);
            int rightNode = 1 + MinDepth(Root.Right);
            return leftNode < rightNode ? leftNode : rightNode;

        }

    }
}
