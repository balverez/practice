import java.util.Deque;
import java.util.LinkedList;

public class Solution
{
    /**
     * Returns the minimum depth of the the passed
     * binary tree.
     *
     * @param root Root TreeNode of the binary tree.
     * @return Minimum depth of the tree.
     */
    public int minDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        
        Deque<TreeNode> currentLevel = new LinkedList<>();
        Deque<TreeNode> nextLevel = new LinkedList<>();
        nextLevel.offer(root);
        TreeNode node = root;
        int traversals = 0;
        boolean leafFlag = false;
        while (!leafFlag && !nextLevel.isEmpty())
        {
            currentLevel = new LinkedList<>(nextLevel);
            traversals++;

            while (!currentLevel.isEmpty())
            {
                node = currentLevel.poll();
    
                if (node.left == null && node.right == null)
                {
                    leafFlag = true;
                    break;
                }
    
                if (node.left != null)
                {
                    nextLevel.offer(node.left);
                }
    
                if (node.right != null)
                {
                    nextLevel.offer(node.right);
                }
            }
        }

        return traversals;
    }
}
