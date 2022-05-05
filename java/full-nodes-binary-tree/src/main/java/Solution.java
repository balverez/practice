public class Solution {
  /**
   * Returns the number of full nodes in the tree.
   *
   * @param root Root TreeNode of the tree.
   * @return Number of full nodes in the tree.
   */
  public int countFull(TreeNode root)
  {
    if (root == null)
    {
      return 0;
    }

    int count = root.left != null && root.right != null
        ? 1
        : 0;

    count = count + countFull(root.left) + countFull(root.right);

    return count;
  }
}
