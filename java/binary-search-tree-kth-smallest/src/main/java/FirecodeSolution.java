import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns the data of the kth smallest node
   * in the passed binary search tree.
   *
   * @param root Root TreeNode of the binary search tree.
   * @param k    Target (kth smallest).
   * @return Data of the Kth smallest node.
   */
  public int kthSmallest(TreeNode root, int k) {
    List<Integer> dataValues = new LinkedList<>();
    buildInOrder(root, dataValues);
    return dataValues.get(k - 1);
  }

  private void buildInOrder(TreeNode node, List<Integer> dataValues) {
    if (node != null) {
      buildInOrder(node.left, dataValues);
      dataValues.add(node.data);
      buildInOrder(node.right, dataValues);
    }
  }
}