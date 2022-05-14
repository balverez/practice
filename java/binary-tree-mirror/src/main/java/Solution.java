public class Solution {
    /**
     * Mirrors the input binary tree in-place and
     * returns its root.
     *
     * @param root Root TreeNode of the tree.
     * @return Root TreeNode of the mirrored tree.
     */
    public TreeNode mirrorTree(TreeNode root)
    {
        mirror(root);
        return root;
    }

    private void mirror(TreeNode root)
    {
        if (root != null)
        {
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            mirror(root.left);
            mirror(root.right);
        }
    }
}