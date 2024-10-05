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
        public TNode Right;
        public  TNode Left;
        public TNode(int data)
        {
            this.data = data;
            Right = null;
            Left = null;
        }
    }
}
