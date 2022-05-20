public class FirecodeSolution {
  /**
   * Mirrors the input binary tree in-place and
   * returns its root.
   *
   * @param root Root TreeNode of the tree.
   * @return Root TreeNode of the mirrored tree.
   */
  public TreeNode mirrorTree(TreeNode root) {
    if (root == null) return null;
    swapChildren(root);
    mirrorTree(root.left);
    mirrorTree(root.right);
    return root;
  }

  private void swapChildren(TreeNode node) {
    TreeNode temp = node.left;
    node.left = node.right;
    node.right = temp;
  }
}