namespace SameTree
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p != null ^ q != null)
                return false;
            else if (p == null)
                return true;

            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}