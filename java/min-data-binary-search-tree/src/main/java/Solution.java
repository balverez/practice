public class Solution {
    /**
     * Returns the minimum data value present in the passed
     * binary search tree.
     *
     * @param root Root TreeNode of the binary search tree.
     * @return Minimum integer data value in the tree.
     */
    public int minData(TreeNode root) {
        int min = Integer.MAX_VALUE;

        if (root == null)
        {
            return min;
        }

        return Math.min(root.data, minData(root.left));
    }
}