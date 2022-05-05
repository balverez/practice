public class Solution {
  /**
   * Returns the height of the binary tree.
   *
   * @param root Root node of the binary tree.
   * @return Integer height of the tree.
   */
  public int getHeight(TreeNode root) {
    if (root == null)
    {
      return 0;
    }

    int height = 1;

    height = height + Math.max(getHeight(root.left), getHeight(root.right));

    return height;
  }
}