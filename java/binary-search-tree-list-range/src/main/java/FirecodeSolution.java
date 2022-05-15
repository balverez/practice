import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns all data present in the bst in the
   * range [a,b].
   *
   * @param root Root TreeNode of the binary search tree.
   * @param a    Lower inclusive bound of the range.
   * @param b    Upper inclusive bound of the range.
   * @return List of data in the tree within the range.
   */
  public List<Integer> listInRange(TreeNode root, int a, int b) {
    List<Integer> dataValues = new LinkedList<>();
    buildInOrder(root, dataValues, a, b);
    return dataValues;
  }

  private void buildInOrder(TreeNode node, List<Integer> dataValues, int a, int b) {
    if (node != null) {
      if (a < node.data) buildInOrder(node.left, dataValues, a, b);
      if (node.data >= a && node.data <= b) dataValues.add(node.data);
      if (b > node.data) buildInOrder(node.right, dataValues, a, b);
    }
  }
}