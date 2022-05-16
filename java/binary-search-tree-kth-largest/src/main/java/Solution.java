import java.util.LinkedList;
import java.util.List;

public class Solution
{
  /**
   * Returns the data of the kth smallest node
   * in the passed binary search tree.
   *
   * @param root Root TreeNode of the binary search tree.
   * @param k    Target (kth smallest).
   * @return Data of the Kth smallest node.
   */
  public int kthLargest(TreeNode root, int k)
  {
    List<Integer> data = new LinkedList<>();
    buildInOrder(root, data);
    return data.get(data.size() - k);
  }

  private void buildInOrder(TreeNode root, List<Integer> data)
  {
    if (root != null)
    {
      buildInOrder(root.left, data);
      data.add(root.data);
      buildInOrder(root.right, data);
    }
  }
}
