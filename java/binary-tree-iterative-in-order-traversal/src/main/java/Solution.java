import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;

public class Solution
{
  /**
   * Returns a list of integers depicting the data
   * of the nodes of the input tree, traversed with
   * pre-order iterative traversal.
   *
   * @param root Root TreeNode.
   * @return List of node data.
   */
  public List<Integer> inOrder(TreeNode root)
  {
    List<Integer> result = new ArrayList<>();
    if (root == null)
    {
      return result;
    }

    Deque<TreeNode> stack = new LinkedList<>();
    TreeNode iterator = root;
    while (iterator != null || !stack.isEmpty())
    {
      while (iterator != null)
      {
        stack.push(iterator);
        iterator = iterator.left;
      }
      
      iterator = stack.pop();
      result.add(iterator.data);
      iterator = iterator.right;
    }

    return result;
  }
}
