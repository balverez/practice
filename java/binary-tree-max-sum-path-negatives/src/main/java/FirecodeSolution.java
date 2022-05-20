public class FirecodeSolution {
  /**
   * Returns the maximum sum along two nodes
   * in the provided binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Maximum sum path along two nodes in the tree.
   */
  public int maxPathSumWithNeg(TreeNode root) {
    int[] maxSumHolder = {Integer.MIN_VALUE};
    search(root, maxSumHolder);
    return maxSumHolder[0];
  }

  /**
   * Recursively returns the max child sum at each node,
   * updating the max sum holder in the process.
   *
   * @param node         Tree node to begin the search at.
   * @param maxSumHolder Boxed max sum holder array to update.
   * @return Max child sum - the max path sum for the children of the node.
   */
  private int search(TreeNode node, int[] maxSumHolder) {
    if (node == null) return 0;
    int leftMaxSum = Math.max(0, search(node.left, maxSumHolder));
    int rightMaxSum = Math.max(0, search(node.right, maxSumHolder));
    maxSumHolder[0] = Math.max(
      maxSumHolder[0],
      node.data + leftMaxSum + rightMaxSum
    );
    return Math.max(node.data + leftMaxSum, node.data + rightMaxSum);
  }
}