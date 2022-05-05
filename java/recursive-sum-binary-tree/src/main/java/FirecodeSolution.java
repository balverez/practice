public class FirecodeSolution {
  /**
   * Returns the sum of all node data in the tree.
   *
   * @param root Root TreeNode.
   * @return Sum of all node data.
   */
  public int sumNodes(TreeNode root) {
    if (root == null)
      return 0;
    else
      return root.data + sumNodes(root.left) + sumNodes(root.right);
  }
}