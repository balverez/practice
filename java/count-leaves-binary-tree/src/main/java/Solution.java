public class Solution {
    /**
     * Returns the maximum node data of the passed
     * binary tree.
     *
     * @param root Root TreeNode.
     * @return Maximum data value.
     */
    public int numLeaves(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        int count = (root.left == null && root.right == null ? 1 : 0)
            + numLeaves(root.left)
            + numLeaves(root.right);

        return count;
    }
}
