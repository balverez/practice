import java.util.Deque;
import java.util.LinkedList;

public class FirecodeSolution {
  /**
   * Returns the max sum level's index.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Index of the max sum level.
   */
  public int maxSumLevel(TreeNode root) {
    int currentLevelIndex = 0, currentSum = root.data;
    int maxSumLevelIndex = currentLevelIndex, maxSum = currentSum;
    Deque<TreeNode> curLevelQueue = new LinkedList<>(), nextLevelQueue = new LinkedList<>();
    curLevelQueue.offer(root);
    while (!curLevelQueue.isEmpty()) {
      TreeNode node = curLevelQueue.poll();
      currentSum += node.data;
      if (node.left != null) nextLevelQueue.offer(node.left);
      if (node.right != null) nextLevelQueue.offer(node.right);
      if (curLevelQueue.isEmpty()) {
        if (maxSum < currentSum) {
          maxSum = currentSum;
          maxSumLevelIndex = currentLevelIndex;
        }
        currentSum = 0;
        currentLevelIndex += 1;
        curLevelQueue = nextLevelQueue;
        nextLevelQueue = new LinkedList<>();
      }
    }
    return maxSumLevelIndex;
  }
}