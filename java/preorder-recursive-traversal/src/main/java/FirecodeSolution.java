import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns an integer list with data of nodes
   * visited with pre-order traversal.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Integer list containing data of visited nodes.
   */
  public List<Integer> preOrder(TreeNode root) {
    return buildPreOrder(root, new LinkedList<>());
  }

  /**
   * Helper builder function.
   *
   * @param node Root TreeNode.
   * @param out  Output list.
   * @return Output list.
   */
  private List<Integer> buildPreOrder(TreeNode node, List<Integer> out) {
    if (node != null) {
      out.add(node.data);
      buildPreOrder(node.left, out);
      buildPreOrder(node.right, out);
    }
    return out;
  }
}