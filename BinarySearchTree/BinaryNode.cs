using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryNode
    {
        private int key;
        private int height;
        private BinaryNode left, right = null;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public BinaryNode Left
        {
            get { return left; }
            set { left = value; }
        }
        public BinaryNode Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}
