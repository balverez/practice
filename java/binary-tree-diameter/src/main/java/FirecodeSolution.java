public class FirecodeSolution {
  /**
   * Returns the diameter of the binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Integer diameter of the tree.
   */
  public int treeDiameter(TreeNode root) {
    int[] diameterHolder = {0};
    search(root, diameterHolder);
    return diameterHolder[0];
  }

  /**
   * Recursive helper method that returns the height of the passed
   * binary tree node. It also updates a container variable
   * with the maximum diameter encountered so far.
   *
   * @param node           Node of the binary tree.
   * @param diameterHolder Pass by reference max diameter.
   * @return Height of the binary tree.
   */
  private int search(TreeNode node, int[] diameterHolder) {
    if (node == null) return 0;
    int leftHeight = search(node.left, diameterHolder);
    int rightHeight = search(node.right, diameterHolder);
    diameterHolder[0] = Math.max(diameterHolder[0], 1 + leftHeight + rightHeight);
    return 1 + Math.max(leftHeight, rightHeight);
  }
}