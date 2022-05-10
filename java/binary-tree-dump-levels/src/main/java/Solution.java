import java.util.ArrayList;
import java.util.Deque;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class Solution
{
    /**
     * Dumps the levels of a tree as a nested list.
     *
     * @param root Root TreeNode of the binary tree.
     * @return Tree nodes' data dumped as a nested list
     */
    public List<List<Integer>> dumpTree(TreeNode root)
    {
        List<List<Integer>> result = new LinkedList<List<Integer>>();
        if (root == null)
        {
            return result;
        }

        List<Integer> levelData = new LinkedList<>();
        Deque<TreeNode> currentLevel = new LinkedList<>();
        Deque<TreeNode> nextLevel = new LinkedList<>();
        currentLevel.offer(root);
        TreeNode node;
        while (!currentLevel.isEmpty())
        {
            node = currentLevel.poll();
            levelData.add(node.data);
            
            if (node.left != null)
            {
                nextLevel.offer(node.left);
            }

            if (node.right != null)
            {
                nextLevel.offer(node.right);
            }

            if (currentLevel.isEmpty())
            {
                result.add(levelData);
                levelData = new LinkedList<>();
                currentLevel = new LinkedList<>(nextLevel);
                nextLevel = new LinkedList<>();
            }
        }

        return result;
    }
}