import java.util.Deque;
import java.util.LinkedList;

public class FirecodeSolution {
  /**
   * Returns the maximum data value present in the passed
   * binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Maximum integer data value in the tree.
   */
  public int maxData(TreeNode root) {
    Deque<TreeNode> queue = new LinkedList<>();
    queue.offer(root);
    int max = Integer.MIN_VALUE;
    while (!queue.isEmpty()) {
      TreeNode node = queue.poll();
      if (node != null) {
        max = Math.max(node.data, max);
        queue.offer(node.left);
        queue.offer(node.right);
      }
    }
    return max;
  }
}