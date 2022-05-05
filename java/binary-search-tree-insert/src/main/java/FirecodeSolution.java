public class FirecodeSolution {
  /**
   * Inserts a new node with data = n into the
   * passed binary search tree.
   *
   * @param root Root TreeNode of the binary search tree.
   * @param n    Integer to set the `data` of the new node to.
   * @return Root TreeNode of the modified tree.
   */
  public TreeNode insert(TreeNode root, int n) {
    if (root == null) root = new TreeNode(n);
    else if (n < root.data) root.left = insert(root.left, n);
    else if (n > root.data) root.right = insert(root.right, n);
    return root;
  }
}