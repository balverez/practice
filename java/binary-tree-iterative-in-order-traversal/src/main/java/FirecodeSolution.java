import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns a list of integers depicting the data
   * of the nodes of the input tree, traversed with
   * in-order iterative traversal.
   *
   * @param root Root TreeNode.
   * @return List of node data.
   */
  public List<Integer> inOrder(TreeNode root) {
    List<Integer> out = new ArrayList<>();
    Deque<TreeNode> stack = new LinkedList<>();
    TreeNode iterator = root;
    while (iterator != null || !stack.isEmpty()) {
      while (iterator != null) {
        stack.push(iterator);
        iterator = iterator.left;
      }
      iterator = stack.pop();
      out.add(iterator.data);
      iterator = iterator.right;
    }
    return out;
  }
}