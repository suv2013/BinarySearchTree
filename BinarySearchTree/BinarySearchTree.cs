using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private BinaryNode root;
        BinaryNode Root
        {
            get { return root; }
        }
        public BinarySearchTree()
        {
            this.root = null;
        }

        private BinaryNode createNewNode(int val)
        {
            BinaryNode node = new BinaryNode();
            node.Key = val;
            return node;
        }

        public void insertBinaryNode(int value)
        {
            root = insertBinaryNode(root, value);
        }

        private BinaryNode insertBinaryNode(BinaryNode currentNode, int value)
        {
            if(currentNode == null)
            {
                Console.WriteLine("Value " + value + "inserted in the BST");
                return createNewNode(value);                
            }
            else if(value <= currentNode.Key)
            {
                currentNode.Left = insertBinaryNode(currentNode.Left, value);
                return currentNode;
            }
            else
            {
                currentNode.Right = insertBinaryNode(currentNode.Right, value);
                return currentNode;
            }
        }

        //Level Oder Traversal
        public void printBSTGraphically()
        {
            Queue<BinaryNode> queue = new Queue<BinaryNode>();
            Queue<int> level = new Queue<int>();

            int currentLevel = 1;
            bool previousLevelAllNull = false;
            queue.Enqueue(root);
            level.Enqueue(1);

            if(root == null)
            {
                Console.WriteLine("The tree is empty");
                return;
            }
            while(queue.Count > 0)
            {
                if(level.Peek() == currentLevel)
                {
                    BinaryNode currentNode = queue.Dequeue();
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left); level.Enqueue(currentLevel + 1);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right); level.Enqueue(currentLevel + 1);
                    }
                    
                    previousLevelAllNull = false;
                    Console.Write(currentNode.Key + "  ");
                    level.Dequeue();
                }
                else
                {
                    Console.WriteLine("\n");
                    currentLevel++;
                    if (previousLevelAllNull == true) { break; }
                    previousLevelAllNull = true;
                }
            }

            Console.WriteLine("\n");
        }

        public void searchValue(int value)
        {
            searchValue(root, value);
        }

        private void searchValue(BinaryNode currentNode, int value)
        {
            if(currentNode == null)
            {
                Console.WriteLine("Value doesnot exist");
                return;
            }
            else
            {
                if(currentNode.Key == value)
                {
                    Console.WriteLine("Value " + value + " found in the tree.");
                }
                else if( value < currentNode.Key)
                {
                    searchValue(currentNode.Left, value);
                }
                else
                {
                    searchValue(currentNode.Right, value);
                }
            }
        }

        public void deleteValue(int value)
        {
            deleteValue(root, value);
        }

        private void deleteValue(BinaryNode currentNode, int value)
        {
            if(currentNode == null)
            {
                Console.WriteLine("Value doesnot exist");
                return;
            }
            if(value < currentNode.Key)
            {
                deleteValue(currentNode.Left, value);
            }
            else if(value > currentNode.Key)
            {
                deleteValue(currentNode.Right, value);
            }
            else
            {
                if(currentNode.Left != null && currentNode.Right != null) //for both left and right Node Present
                {
                    BinaryNode minRightNode = minimumNode(currentNode.Right); // Find min node from Right
                    currentNode.Key = minRightNode.Key; // Replace currentnode with Min node value
                    deleteValue(currentNode.Right, minRightNode.Key); // Delete the min Right Node from tree
                }
                else if(currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                }
                else if(currentNode.Right != null)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    currentNode = null;
                }
            }
        }

        public static BinaryNode minimumNode(BinaryNode currentNode)
        {
            if(currentNode.Left == null)
            {
                return currentNode;
            }
            else
            {
                return minimumNode(currentNode.Left);
            }
        }
    }
}
