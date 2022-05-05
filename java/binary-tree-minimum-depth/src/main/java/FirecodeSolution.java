import java.util.Deque;
import java.util.LinkedList;

public class FirecodeSolution {
  /**
   * Returns the minimum depth of the the passed
   * binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Minimum depth of the tree.
   */
  public int minDepth(TreeNode root) {
    if (root == null) return 0;
    int depth = 1;
    Deque<TreeNode> curLevelQueue = new LinkedList<>(), nextLevelQueue = new LinkedList<>();
    curLevelQueue.offer(root);
    while (!curLevelQueue.isEmpty()) {
      TreeNode node = curLevelQueue.poll();
      if (node.left == null && node.right == null) return depth;
      if (node.left != null) nextLevelQueue.offer(node.left);
      if (node.right != null) nextLevelQueue.offer(node.right);
      if (curLevelQueue.isEmpty()) {
        depth++;
        curLevelQueue = nextLevelQueue;
        nextLevelQueue = new LinkedList<>();
      }
    }
    return depth;
  }
}