import java.util.Deque;
import java.util.LinkedList;

public class Solution {
  /**
   * Returns the max sum level's index.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Index of the max sum level.
   */
  public int maxSumLevel(TreeNode root) {
    Deque<TreeNode> currentLevel = new LinkedList<>();
    currentLevel.offer(root);
    Deque<TreeNode> nextLevel = new LinkedList<>();
    
    int maxLevel = Integer.MIN_VALUE;
    int maxLevelSum = Integer.MIN_VALUE;
    int level = 0;
    int levelSum = 0;
    TreeNode node;
    while (!currentLevel.isEmpty()) {
      node = currentLevel.poll();
      levelSum += node.data;
      
      if (node.left != null) {
        nextLevel.offer(node.left);
      }
      
      if (node.right != null) {
        nextLevel.offer(node.right);
      }
      
      if (currentLevel.isEmpty()) {
        if (levelSum > maxLevelSum) {
          maxLevel = level;
          maxLevelSum = levelSum;
        }
        
        level++;
        levelSum = 0;
        currentLevel = nextLevel;
        nextLevel = new LinkedList<>();
      }
    }
    
    return maxLevel;
  }
}