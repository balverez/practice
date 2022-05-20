public class Solution {
  /**
   * Returns the maximum sum along two nodes
   * in the provided binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Maximum sum path along two nodes in the tree.
   */
  public int maxPathSumWithNeg(TreeNode root) {
    if (root == null) {
      return 0;
    }
    
    int[] maxSumBox = { Integer.MIN_VALUE };
    BuildMaxSumPath(root, maxSumBox);
    return maxSumBox[0];
  }
  
  private int BuildMaxSumPath(TreeNode root, int[] maxSumBox) {
    if (root == null) {
      return 0;
    }
    
    int leftMax = Math.max(0, BuildMaxSumPath(root.left, maxSumBox));
    int rightMax = Math.max(0, BuildMaxSumPath(root.right, maxSumBox));
    
    maxSumBox[0] = Math.max(maxSumBox[0], root.data + leftMax + rightMax);
    
    return Math.max(root.data + leftMax, root.data + rightMax);
  }
}