import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;

public class Solution {
  /**
   * Returns a list of integers depicting the data
   * of the nodes of the input tree, traversed with
   * pre-order iterative traversal.
   *
   * @param root Root TreeNode.
   * @return List of node data.
   */
  public List<Integer> preOrder(TreeNode root)
  {
    List<Integer> result = new ArrayList<>();
    if (root == null)
    {
      return result;
    }

    Deque<TreeNode> stack = new LinkedList<>();
    stack.push(root);

    while (!stack.isEmpty())
    {
      TreeNode node = stack.pop();
      result.add(node.data);

      if (node.right != null)
      {
        stack.push(node.right);
      }

      if (node.left != null)
      {
        stack.push(node.left);
      }
    }

    return result;
  }
}