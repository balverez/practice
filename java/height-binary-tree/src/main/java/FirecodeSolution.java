public class FirecodeSolution {
  /**
   * Returns the height of the binary tree.
   *
   * @param root Root node of the binary tree.
   * @return Integer height of the tree.
   */
  public int getHeight(TreeNode root) {
    if (root == null) {
      return 0;
    }
    return 1 + Math.max(getHeight(root.left), getHeight(root.right));
  }
}