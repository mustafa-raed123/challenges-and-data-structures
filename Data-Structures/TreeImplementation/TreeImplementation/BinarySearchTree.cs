using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree 
    {
        public TNode Root ;
        public BinarySearchTree(int data)
        {
            Root = new TNode(data);
        }
        public void Insert(int data) => Root = Insert(Root, data);
        public TNode Insert(TNode Root, int data)
        {
            if (Root == null) return Root = new TNode(data);
            if (data < Root.data)
            {
                Root.left = Insert(Root.left, data);
            }
            else if (data > Root.data)
            {
                Root.right = Insert(Root.right, data);
            }
            return Root;
        }
        public TNode Search(TNode Root, int data)
        {
            if (Root == null || Root.data == data)
                return Root;              
            if (data < Root.data)            
                return Search(Root.left, data);              
            else            
                return Search(Root.right, data);             
        }
        public void Remove( int data) => Remove(Root, data);

        public TNode Remove(TNode Root, int data)
        {
            if (Root == null) return null;
            if (data < Root.data)
            {
                Root.left = Remove(Root.left, data);
            }
            else if (data > Root.data)
            {
                Root.right = Remove(Root.right, data);
            }
            else
            {
                if (Root.left == null && Root.right == null)
                {
                    return null;
                }
                if (Root.left == null)
                {
                    return Root.right;  
                }
                if (Root.right == null)
                {
                    return Root.left;  
                }
             TNode minNode = FindMin(Root.right);
             Root.data = minNode.data;
             Root.right = Remove(Root.right, minNode.data);
            }
            return Root;
        }
        public TNode FindMin(TNode node)
        {
            while (node.left != null)
            {
                node = node.left;  
            }
            return node;
        }
    }
}
