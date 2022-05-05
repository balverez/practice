import java.util.Deque;
import java.util.LinkedList;

public class FirecodeSolution {
  /**
   * Finds and returns the deepest node of the
   * binary tree.
   *
   * @param root Root TreeNode of the tree.
   * @return Integer data of the deepest node.
   */
  public int deepestNode(TreeNode root) {
    Deque<TreeNode> queue = new LinkedList<>();
    TreeNode node = root;
    queue.offer(node);
    while (!queue.isEmpty()) {
      node = queue.poll();
      if (node.left != null) queue.offer(node.left);
      if (node.right != null) queue.offer(node.right);
    }
    return node.data;
  }
}