import java.util.LinkedList;
import java.util.List;

public class Solution {
  /**
   * Returns all data present in the bst in the
   * range [a,b].
   *
   * @param root Root TreeNode of the binary search tree.
   * @param a    Lower inclusive bound of the range.
   * @param b    Upper inclusive bound of the range.
   * @return List of data in the tree within the range.
   */
  public List<Integer> listInRange(TreeNode root, int a, int b) {
    List<Integer> result = new LinkedList<>();
    buildInOrder(root, result, a, b);
    return result;
  }

  private void buildInOrder(TreeNode root, List<Integer> result, int a, int b)
  {
    if (root != null)
    {
      buildInOrder(root.left, result, a, b);
      if (root.data >= a && root.data <= b)
      {
        result.add(root.data);
      }
      buildInOrder(root.right, result, a, b);
    }
  }
}