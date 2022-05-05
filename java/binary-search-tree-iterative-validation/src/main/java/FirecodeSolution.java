import java.util.Deque;
import java.util.LinkedList;

public class FirecodeSolution {
  /**
   * Checks if the passed root tree node belongs to
   * a valid binary search tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return True if the passed node is the root of a valid BST.
   */
  public Boolean isValidBst(TreeNode root) {
    if (root == null) return true;
    Deque<EnrichedTreeNode> queue = new LinkedList<>();
    queue.offer(new EnrichedTreeNode(root, Integer.MIN_VALUE, Integer.MAX_VALUE));
    while (!queue.isEmpty()) {
      EnrichedTreeNode node = queue.poll();
      if (!node.isValid()) return false;
      if (node.left != null) {
        queue.offer(new EnrichedTreeNode(node.left, node.min, node.data));
      }
      if (node.right != null) {
        queue.offer(new EnrichedTreeNode(node.right, node.data, node.max));
      }
    }
    return true;
  }

  class EnrichedTreeNode extends TreeNode {
    private final int min, max;

    EnrichedTreeNode(TreeNode node, int min, int max) {
      super(node.data, node.left, node.right);
      this.min = min;
      this.max = max;
    }

    boolean isValid() {
      return data > min && data < max;
    }
  }
}