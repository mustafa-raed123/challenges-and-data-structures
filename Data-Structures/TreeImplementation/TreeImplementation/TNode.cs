using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class TNode
    {
       public int data;
        public TNode right;
        public  TNode left;
        public TNode(int data)
        {
            this.data = data;
            right = null;
            left = null;
        }
    }
}
