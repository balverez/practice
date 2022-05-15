import java.util.LinkedList;
import java.util.List;

public class Solution {
    /**
     * Returns the `data` of all ancestors of a node with
     * data = n.
     *
     * @param root Root TreeNode of the binary tree.
     * @param n    Data of the target node.
     * @return List containing data of all ancestors of the target node.
     */
    public List<Integer> listAncestors(TreeNode root, int n)
    {
        List<Integer> ancestors = new LinkedList<>();
        recurse(root, ancestors, n);
        return ancestors;
    }

    private Boolean recurse(TreeNode root, List<Integer> ancestors, int n)
    {
        if (root == null)
        {
            return false;
        }
        else if (root.data == n)
        {
            return true;
        }
        else if (recurse(root.left, ancestors, n) || recurse(root.right, ancestors, n))
        {
            ancestors.add(root.data);
            return true;
        }
        else
        {
            return false;
        }
    }
}