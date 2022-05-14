using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDumpLevels
{
    internal class TreeNode
    {
        public int Data { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(int data, TreeNode left, TreeNode right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
