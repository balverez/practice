public class Solution {
  /**
   * Returns the diameter of the binary tree.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Integer diameter of the tree.
   */
  public int treeDiameter(TreeNode root) {
    int[] longestPathBox = { 0 };
    if (root == null) {
      return longestPathBox[0];
    }
    
    BuildLongestPath(root, longestPathBox);
    return longestPathBox[0];
  }
  
  private int BuildLongestPath(TreeNode root, int[] longestPathBox) {
    if (root == null) {
      return 0;
    }
    
    int leftPath = BuildLongestPath(root.left, longestPathBox);
    int rightPath = BuildLongestPath(root.right, longestPathBox);
    
    longestPathBox[0] = Math.max(longestPathBox[0], 1 + leftPath + rightPath);
    
    return Math.max(++leftPath, ++rightPath);
  }
}