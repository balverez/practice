using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeMirror
{
    internal class TreeNode
    {
        internal int Data { get; set; }
        internal TreeNode? Left { get; set; }
        internal TreeNode? Right { get; set; }

        internal TreeNode(int data, TreeNode left, TreeNode right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        internal TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
