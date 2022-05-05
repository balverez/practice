import java.util.Deque;
import java.util.LinkedList;

public class Solution {
  /**
   * Returns the sum of all nodes' data in the tree.
   *
   * @param root Root TreeNode of the tree.
   * @return Sum of all nodes' data.
   */
  public int sumNodes(TreeNode root) {
    int sum = 0;

    if (root == null)
    {
        return sum;
    }
    
    Deque<TreeNode> queue = new LinkedList<>();
    queue.offer(root);
    
    TreeNode node;
    while (!queue.isEmpty())
    {
        node = queue.poll();
        sum += node.data;
        if (node.left != null)
        {
            queue.offer(node.left);
        }

        if (node.right != null)
        {
            queue.offer(node.right);
        }
    }
    
    return sum;
  }
}