namespace ValidateBinarySearchTree
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public bool IsValidBST(TreeNode? root)
        {
            Stack<TreeNode> stack = new();
            int? previous = null;
            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();

                if (previous != null && previous >= root.val)
                    return false;

                previous = root.val;
                root = root.right;
            }

            return true;
        }
    }
}