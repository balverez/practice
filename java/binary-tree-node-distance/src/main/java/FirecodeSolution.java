public class FirecodeSolution {
  /**
   * Returns the distance between the root and
   * a node with data = target.
   *
   * @param root   Root TreeNode.
   * @param target Target integer.
   * @return Distance of the target node from the root.
   */
  public int nodeDistance(TreeNode root, int target) {
    return dfsDistance(root, target, 1);
  }

  /**
   * Helper depth first search method.
   *
   * @param node   Tree node.
   * @param target Target integer.
   * @param step   The current distance from the root.
   * @return The distance to the target integer from node.
   */
  private int dfsDistance(TreeNode node, int target, int step) {
    if (node == null) return Integer.MAX_VALUE;
    else if (node.data == target) return step;
    else return Math.min(
        dfsDistance(node.left, target, step + 1),
        dfsDistance(node.right, target, step + 1)
      );
  }
}