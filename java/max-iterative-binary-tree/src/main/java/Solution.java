import java.time.OffsetDateTime;
import java.util.Deque;
import java.util.LinkedList;

public class Solution {
  /**
   * Returns the maximum data value present in the passed
   * binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Maximum integer data value in the tree.
   */
  public int maxData(TreeNode root) {
    int max = Integer.MIN_VALUE;
    Deque<TreeNode> queue = new LinkedList<TreeNode>();
    queue.offer(root);

    TreeNode node = null;
    while (!queue.isEmpty())
    {
      node = queue.poll();

      max = Math.max(node.data, max);

      if (node.left != null)
      {
        queue.offer(node.left);
      }

      if (node.right != null)
      {
        queue.offer(node.right);
      }
    }

    return max;
  }
}
