public class FirecodeSolution {
  /**
   * Returns the size of the binary tree.
   *
   * @param root Root TreeNode.
   * @return Integer size of the binary tree.
   */
  public int size(TreeNode root) {
    if (root == null) {
      return 0;
    }
    return 1 + size(root.left) + size(root.right);
  }
}