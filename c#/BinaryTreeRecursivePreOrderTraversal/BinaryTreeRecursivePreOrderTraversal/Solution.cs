using System.Collections.Generic;

namespace BinaryTreeRecursivePreOrderTraversal
{
    internal class Solution
    {
        internal List<int> PreOrder(TreeNode? root)
        {
            List<int> data = new();
            Recurse(root, data);
            return data;
        }

        //O(n) time
        //O(n) space
        internal void Recurse(TreeNode? root, List<int> data)
        {
            if (root != null)
            {
                data.Add(root.Data);
                Recurse(root.Left, data);
                Recurse(root.Right, data);
            }
        }
    }
}