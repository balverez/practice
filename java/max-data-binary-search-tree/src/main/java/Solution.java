public class Solution {
    /**
     * Returns the minimum data value present in the passed
     * binary search tree.
     *
     * @param root Root TreeNode of the binary search tree.
     * @return Minimum integer data value in the tree.
     */
    public int maxData(TreeNode root) {
        int max = Integer.MIN_VALUE;

        if (root == null)
        {
            return max;
        }

        return Math.max(root.data, maxData(root.right));
    }
}