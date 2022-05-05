public class Solution {
    /**
     * Returns the maximum node data of the passed
     * binary tree.
     *
     * @param root Root TreeNode.
     * @return Maximum data value.
     */
    public int maxData(TreeNode root) {
        int max = Integer.MIN_VALUE;

        if (root == null)
        {
            return max;
        }
        
        max = root.data;
        int leftMax = maxData(root.left);
        if (leftMax > max)
        {
            max = leftMax;
        }

        int rightMax = maxData(root.right);
        if (rightMax > max)
        {
            max = rightMax;
        }

        return max;
    }
}