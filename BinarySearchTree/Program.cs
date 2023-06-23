using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearchTree;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bST = new BinarySearchTree();
            bST.insertBinaryNode(100);
            bST.insertBinaryNode(80);
            bST.insertBinaryNode(110);
            bST.insertBinaryNode(90);
            bST.insertBinaryNode(70);
            bST.insertBinaryNode(105);
            bST.insertBinaryNode(115);
            bST.printBSTGraphically();

            bST.searchValue(65);

            bST.deleteValue(110);

            bST.printBSTGraphically();

            Console.ReadKey();
        }
    }
}
