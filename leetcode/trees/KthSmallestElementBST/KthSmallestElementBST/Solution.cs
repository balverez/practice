namespace KthSmallestElementBST
{
    public class Solution
    {
        //O(h + k) time, where h is the height of the tree and k is the index of the kth smallest element requested.
        //O(h) space
        public int KthSmallest(TreeNode? root, int k)
        {
            Stack<TreeNode> stack = new();

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                k--;
                if (k == 0)
                    return root.val;

                root = root.right;
            }

            return 0;
        }
    }
}