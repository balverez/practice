namespace SubtreeOfAnotherTree
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            Stack<TreeNode> stack = new();
            stack.Push(root);

            TreeNode iterator;
            while (stack.Count > 0)
            {
                iterator = stack.Pop();
                if (iterator.val == subRoot.val && IsSameTree(iterator, subRoot))
                    return true;

                if (iterator.right != null)
                    stack.Push(iterator.right);

                if (iterator.left != null)
                    stack.Push(iterator.left);
            }

            return false;
        }

        //O(k) time, where k represents the nodes in the subtree
        //O(k) space, where k represents the nodes in the subtree
        private bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p != null ^ q != null)
                return false;
            else if (p == null)
                return true;

            Stack<TreeNode> pStack = new();
            pStack.Push(p);
            Stack<TreeNode> qStack = new();
            qStack.Push(q);

            TreeNode pIterator;
            TreeNode qIterator;
            while (pStack.Count > 0)
            {
                pIterator = pStack.Pop();
                qIterator = qStack.Pop();

                if (pIterator.val != qIterator.val
                    || (pIterator.left != null ^ qIterator.left != null)
                    || (pIterator.right != null ^ qIterator.right != null))
                    return false;

                if (pIterator.right != null)
                {
                    pStack.Push(pIterator.right);
                    qStack.Push(qIterator.right);
                }

                if (pIterator.left != null)
                {
                    pStack.Push(pIterator.left);
                    qStack.Push(qIterator.left);
                }
            }

            return true;
        }
    }
}