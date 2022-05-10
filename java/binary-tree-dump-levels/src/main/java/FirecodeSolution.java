import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Dumps the levels of a tree as a nested list.
   *
   * @param root Root TreeNode of the binary tree.
   * @return Tree nodes' data dumped as a nested list
   */
  public List<List<Integer>> dumpTree(TreeNode root) {
    List<List<Integer>> out = new ArrayList<>();
    if (root == null) return out;
    Deque<TreeNode> curLevelQueue =
      new LinkedList<>(), nextLevelQueue = new LinkedList<>();
    curLevelQueue.offer(root);
    out.add(List.of(root.data));
    while (!curLevelQueue.isEmpty()) {
      TreeNode node = curLevelQueue.poll();
      if (node.left != null) nextLevelQueue.offer(node.left);
      if (node.right != null) nextLevelQueue.offer(node.right);
      if (curLevelQueue.isEmpty()) {
        if (!nextLevelQueue.isEmpty()) {
          out.add(nextLevelQueue
                    .stream()
                    .map(n -> n.data)
                    .collect(Collectors.toList()));
        }
        curLevelQueue = nextLevelQueue;
        nextLevelQueue = new LinkedList<>();
      }
    }
    return out;
  }
}