public class FirecodeSolution {
  /**
   * Returns the number of leaf nodes in the binary
   * tree.
   *
   * @param root Root TreeNode.
   * @return Number of leaf nodes.
   */
  public int numLeaves(TreeNode root) {
    if (root == null) return 0;
    else if (root.left == null && root.right == null) return 1;
    else return numLeaves(root.left) + numLeaves(root.right);
  }
}
