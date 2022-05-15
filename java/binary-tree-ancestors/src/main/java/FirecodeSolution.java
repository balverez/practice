import java.util.LinkedList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns the `data` of all ancestors of a node with
   * data = n.
   *
   * @param root Root TreeNode of the binary tree.
   * @param n    Data of the target node.
   * @return List containing data of all ancestors of the target node.
   */
  public List<Integer> listAncestors(TreeNode root, int n) {
    List<Integer> out = new LinkedList<>();
    build(root, out, n);
    return out;
  }

  private boolean build(TreeNode node, List<Integer> list, int n) {
    if (node == null) return false;
    else if (node.data == n) return true;
    else if (build(node.left, list, n) || build(node.right, list, n)) {
      list.add(node.data);
      return true;
    } else return false;
  }
}