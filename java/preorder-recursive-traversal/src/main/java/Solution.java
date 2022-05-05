import java.util.LinkedList;
import java.util.List;

public class Solution {
  /**
   * Returns an integer list with data of nodes
   * visited with pre-order traversal.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Integer list containing data of visited nodes.
   */
  public List<Integer> preOrder(TreeNode root)
  {
      return buildPreOrder(root, new LinkedList<Integer>());
  }

  private LinkedList<Integer> buildPreOrder(TreeNode root, LinkedList<Integer> result)
  {
      if (root != null)
      {
          result.add(root.data);
          result = buildPreOrder(root.left, result);
          result = buildPreOrder(root.right, result);
      }

      return result;
  }

}