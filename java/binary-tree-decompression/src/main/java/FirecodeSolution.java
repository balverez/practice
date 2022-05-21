import java.util.*;
import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Deserializes the binary tree passed as a
   * serialized compressed string.
   *
   * @param compressed Serialized binary tree.
   * @return Root of the constructed tree.
   */
  public TreeNode decompress(String compressed) {
    List<TreeNode> treeNodes =
      Arrays.stream(compressed.split(","))
        .map(s -> s.equals("*") ? null : new TreeNode(Integer.parseInt(s)))
        .collect(Collectors.toList());
    Deque<TreeNode> queue = new LinkedList<>();
    TreeNode node = treeNodes.get(0);
    queue.offer(node);
    int childrenAdded = 0;
    for (int i = 1; i < treeNodes.size(); i++) {
      TreeNode nextNode = treeNodes.get(i);
      if (childrenAdded == 0) {
        node = queue.poll();
        node.left = nextNode;
        childrenAdded++;
      } else {
        node.right = nextNode;
        childrenAdded = 0;
      }
      if (nextNode != null) queue.offer(nextNode);
    }
    return treeNodes.get(0);
  }
}