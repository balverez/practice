public class FirecodeSolution {
  /**
   * Returns the maximum data value present in the passed
   * binary search tree.
   *
   * @param root Root TreeNode of the binary search tree.
   * @return Maximum integer data value in the tree.
   */
  public int maxData(TreeNode root) {
    if (root.right == null) return root.data;
    else return maxData(root.right);
  }
}