import java.util.Arrays;
import java.util.LinkedList;
import java.util.stream.Collectors;

public class Solution {
  /**
   * Serializes the binary tree to a string.
   *
   * @param root Root node of the binary tree.
   * @return String representation of a binary tree.
   */
  String serialize(TreeNode root) {
    if (root == null) {
      return "#";
    }
    
    return String.format("%d %s %s", root.data, serialize(root.left), serialize(root.right));
  }

  /**
   * Deserializes the binary tree serialized using the
   * serialize method above.
   *
   * @param serialized Serialized string.
   * @return Root TreeNode of the deserialized tree.
   */
  TreeNode deserialize(String serialized) {
    return preorderDeserialization(
      Arrays.stream(serialized.split(" "))
      .map(s -> s.equals("#") ? null : new TreeNode(Integer.parseInt(s)))
      .collect(Collectors.toCollection(LinkedList::new)));
  }
  
  private TreeNode preorderDeserialization(LinkedList<TreeNode> preOrderNodes) {
    TreeNode node = preOrderNodes.remove();
    
    if (node != null) {
      node.left = preorderDeserialization(preOrderNodes);
      node.right = preorderDeserialization(preOrderNodes);
    }
    
    return node;
  }


  /* Required to test the solution, do not modify */
  public TreeNode serde(TreeNode root) {
    return deserialize(serialize(root));
  }
}