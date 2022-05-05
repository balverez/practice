public class Solution {
    /**
     * Returns the sum of all node data in the tree.
     *
     * @param root Root TreeNode.
     * @return Sum of all node data.
     */
    public int sumNodes(TreeNode root) {
        int sum = 0;

        if (root != null)
        {
            sum += root.data;
            sum += sumNodes(root.left);
            sum += sumNodes(root.right);
        }

        return sum;
    }
}