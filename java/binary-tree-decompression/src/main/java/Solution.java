import java.util.*;
import java.util.stream.Collectors;

public class Solution {
  /**
   * Deserializes the binary tree passed as a
   * serialized compressed string.
   *
   * @param compressed Serialized binary tree.
   * @return Root of the constructed tree.
   */
  public TreeNode decompress(String compressed) {
      List<TreeNode> treeNodes = Arrays.stream(compressed.split(",")).map(s -> s.equals("*") ? null : new TreeNode(Integer.parseInt(s))).collect(Collectors.toList());
      
      Deque<TreeNode> queue = new LinkedList<>();
      queue.offer(treeNodes.get(0));

      boolean noChildrenAdded = true;
      TreeNode node = new TreeNode(Integer.MIN_VALUE);
      TreeNode nextNode;
      for (int i = 1; i < treeNodes.size(); i++) {
          nextNode = treeNodes.get(i);

          if (noChildrenAdded) {
              node = queue.poll();
              node.left = nextNode;
              noChildrenAdded = false;
          } else {
              node.right = nextNode;
              noChildrenAdded = true;
          }

          if (nextNode != null) {
              queue.offer(nextNode);
          }
      }

      return treeNodes.get(0);
  }
}