namespace LowestCommonAncestorOfBST
{
    public class Solution
    {
        //O(n) time, possibly O(logn) if the tree is balanced
        //O(1) space
        public TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode? iterator = root;
            while (iterator != null)
            {
                if (p.val < iterator.val && q.val < iterator.val)
                    iterator = iterator.left;
                else if (p.val > iterator.val && q.val > iterator.val)
                    iterator = iterator.right;
                else
                    return iterator;
            }

            return iterator;
        }
    }
}