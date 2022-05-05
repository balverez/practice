import java.util.Deque;
import java.util.LinkedList;

public class Solution {
    /**
     * Finds and returns the deepest node of the
     * binary tree.
     *
     * @param root Root TreeNode of the tree.
     * @return Integer data of the deepest node.
     */
    public int deepestNode(TreeNode root)
    {
        Deque<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        TreeNode deepest = root;
        while (!queue.isEmpty())
        {
            deepest = queue.poll();

            if (deepest.left != null)
            {
                queue.offer(deepest.left);
            }

            if (deepest.right != null)
            {
                queue.offer(deepest.right);
            }
        }

        return deepest.data;
    }
}