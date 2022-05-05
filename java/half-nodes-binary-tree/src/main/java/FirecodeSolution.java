public class FirecodeSolution {
  /**
   * Returns the number of half nodes in the tree.
   *
   * @param root Root TreeNode of the tree.
   * @return Number of half nodes in the tree.
   */
  public int countHalf(TreeNode root) {
    if (root == null) return 0;
    int nodeWeight = (root.left != null ^ root.right != null) ? 1 : 0;
    return nodeWeight + countHalf(root.left) + countHalf(root.right);
  }
}