public class Solution
{
    /**
     * Checks if the two trees are identical.
     *
     * @param t1 Root TreeNode of the first binary tree.
     * @param t2 Root TreeNode of the second binary tree.
     * @return True if the trees are identical, false otherwise.
     */
    public Boolean areIdentical(TreeNode t1, TreeNode t2)
    {
        if (t1 != null ^ t2 != null)
        {
            return false;
        }
        else if (t1 == null && t2 == null)
        {
            return true;
        }
        else if (t1 != null && t2 != null && t1.data == t2.data)
        {
            return true && areIdentical(t1.left, t2.left) && areIdentical(t1.right, t2.right);
        }

        return false;
    }
}