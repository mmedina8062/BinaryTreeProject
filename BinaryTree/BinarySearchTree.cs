using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        //member variables
        public TreeNode root;
        public int value;
        
      

        //ctor
      
        public BinarySearchTree()
        {
            
        }
        
        //member methods

        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void InorderTraversal()
        {
            if (root != null)
                root.InOrderTraversal();
        }

        public TreeNode FindDataRecursive(int value)
        {
            if (root != null)
            {
                return root.FindDataRecursive(value);
            }
            else
            {
                return null;
            }
        }
    }
}
