using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode
    {
        //member variable
        private int data;
        public int Data
        {
            get { return data; }
        }
        public TreeNode RightNode;
        public TreeNode LeftNode;


        //ctor
        public TreeNode(int value)
        {
            data = value;
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
                if (RightNode == null)
                {
                    RightNode = new TreeNode(value);
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(value);
                }
                else
                {
                    LeftNode.Insert(value); 
                }
            }
        }
        public void InOrderTraversal()
        {
            if (LeftNode != null)
                LeftNode.InOrderTraversal();
            Console.WriteLine(data + " ");

            if (RightNode != null)
                RightNode.InOrderTraversal();
        }

        public TreeNode FindDataRecursive(int value)
        {
            if (value == data)
            {
                return this;
            }
            else if (value < Data && LeftNode != null)
            {
                return LeftNode.FindDataRecursive(value);
            }
            else if (value > data && RightNode != null)
            {
                return RightNode.FindDataRecursive(value);
            }
            else
            {
                return null;
            }
        }
        



        
    }
}
