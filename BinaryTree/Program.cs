using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BinarySearchTree binarySearchTree = new BinarySearchTree();


            binarySearchTree.Insert(110);
            binarySearchTree.Insert(80);
            binarySearchTree.Insert(200);
            binarySearchTree.Insert(210);
            binarySearchTree.Insert(90);
            binarySearchTree.Insert(120);
            binarySearchTree.Insert(135);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(79);
            binarySearchTree.Insert(55);
            binarySearchTree.delete(80);


            Console.WriteLine("Binary Search Tree\n");

            Console.WriteLine("In order traversal from LeftNode to Root to RightNode\n");
            binarySearchTree.InorderTraversal();

            var FoundNode = binarySearchTree.FindDataRecursive(120);
            Console.WriteLine("Match found: " + FoundNode.Data);



            

            

            
        }
    }
}
