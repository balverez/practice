public class Solution {
    /**
     * Returns the maximum node data of the passed
     * binary tree.
     *
     * @param root Root TreeNode.
     * @return Maximum data value.
     */
    public int size(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        return 1 + size(root.left) + size(root.right);
    }
}
