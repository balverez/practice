import java.util.Deque;
import java.util.LinkedList;

public class Solution {
    /**
     * Checks if the binary tree contains the target value.
     *
     * @param root Root TreeNode of the binary tree.
     * @param n    Target integer to search for.
     * @return True if the target value is found, false otherwise.
     */
    public Boolean findNode(TreeNode root, int n) {
        Deque<TreeNode> queue = new LinkedList<>();
        queue.offer(root);

        while (!queue.isEmpty())
        {
            TreeNode node = queue.poll();
            if (node != null)
            {
                if (node.data == n)
                {
                    return true;
                }
                queue.offer(node.left);
                queue.offer(node.right);
            }
        }

        return false;
    }
}
