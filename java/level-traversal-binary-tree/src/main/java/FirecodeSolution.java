import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns a list of integers depicting the data
   * of the nodes of the input tree, traversed with
   * level-order iterative traversal.
   *
   * @param root Root TreeNode
   * @return List of node data.
   */
  public List<Integer> levelOrder(TreeNode root) {
    List<Integer> out = new ArrayList<>();
    if (root == null) return out;
    Deque<TreeNode> queue = new LinkedList<>();
    TreeNode node = root;
    queue.offer(node);
    while (!queue.isEmpty()) {
      node = queue.poll();
      out.add(node.data);
      if (node.left != null) queue.offer(node.left);
      if (node.right != null) queue.offer(node.right);
    }
    return out;
  }
}