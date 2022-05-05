public class FirecodeSolution {
  /**
   * Returns the minimum data value present in the passed
   * binary search tree.
   *
   * @param root Root TreeNode of the binary search tree.
   * @return Minimum integer data value in the tree.
   */
  public int minData(TreeNode root) {
    if (root.left == null) return root.data;
    else return minData(root.left);
  }
}