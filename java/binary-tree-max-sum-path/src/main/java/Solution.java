public class Solution {
    /**
     * Returns the maximum sum along two nodes
     * in the provided binary tree.
     *
     * @param root Root TreeNode of the binary tree.
     * @return Maximum sum path along two nodes in the tree.
     */
    public int maxPathSum(TreeNode root) {
      if (root == null)
      {
        return 0;
      }
      
      int[] maxSum = { 0 };
      buildMaxPath(root, maxSum);
      return maxSum[0];
    }
    
    private int buildMaxPath(TreeNode root, int[] maxSum)
    {
      if (root == null)
      {
        return 0;
      }
      
      int leftMax = buildMaxPath(root.left, maxSum);
      int rightMax = buildMaxPath(root.right, maxSum);
      
      maxSum[0] = Math.max(maxSum[0], root.data + leftMax + rightMax);
      return Math.max(root.data + leftMax, root.data + rightMax);
    }
  }