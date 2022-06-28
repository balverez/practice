namespace ConstructBinaryTree
{
    public class Solution
    {
        public TreeNode? BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 1)
                return new(preorder[0]);

            Dictionary<int, int> inorderMap = new();
            for (int i = 0; i < inorder.Length; i++)
                inorderMap[inorder[i]] = i;

            int preorderIndex = 0;
            TreeNode? root = Recurse(inorderMap, preorder, inorder, ref preorderIndex, 0, preorder.Length - 1);
            return root;
        }

        private TreeNode? Recurse(Dictionary<int, int> inorderMap, int[] preorder, int[] inorder, ref int i, int l, int r)
        {
            if (l > r)
                return null;

            TreeNode root = new(preorder[i++]);
            root.left = Recurse(inorderMap, preorder, inorder, ref i, l, inorderMap[root.val] - 1);
            root.right = Recurse(inorderMap, preorder, inorder, ref i, inorderMap[root.val] + 1, r);

            return root;
        }
    }
}