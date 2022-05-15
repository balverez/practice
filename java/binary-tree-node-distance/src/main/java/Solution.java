public class Solution {
    /**
     * Returns the distance between the root and
     * a node with data = target.
     *
     * @param root   Root TreeNode.
     * @param target Target integer.
     * @return Distance of the target node from the root.
     */
    public int nodeDistance(TreeNode root, int target)
    {
        return searchTree(root, target, 1);
    }

    private int searchTree(TreeNode root, int target, int distance)
    {
        if (root == null)
        {
            return Integer.MAX_VALUE;
        }
        else if (root.data == target)
        {
            return distance;
        }
        else
        {
            return Math.min(searchTree(root.left, target, distance + 1), searchTree(root.right, target, distance + 1));
        }
    }
  }