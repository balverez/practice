import java.util.Deque;
import java.util.LinkedList;

public class Solution
{
  /**
   * Checks if the passed root tree node belongs to
   * a valid binary search tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return True if the passed node is the root of a valid BST.
   */
  public Boolean isValidBst(TreeNode root)
  {
    if (root == null)
    {
      return true;
    }

    Deque<TreeNode> queue = new LinkedList<>();
    queue.offer(root);

    TreeNode node;
    while (!queue.isEmpty())
    {
      node = queue.poll();

      if (node.left != null)
      {
        if (node.left.data > node.data)
        {
          return false;
        }

        queue.offer(node.left);
      }

      if (node.right != null)
      {
        if (node.right.data < node.data)
        {
          return false;
        }

        queue.offer(node.right);
      }
    }

    return true;
  }
}
