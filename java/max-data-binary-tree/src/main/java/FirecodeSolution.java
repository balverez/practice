public class FirecodeSolution {
    /**
     * Returns the maximum node data of the passed
     * binary tree.
     *
     * @param root Root TreeNode.
     * @return Maximum data value.
     */
    public int maxData(TreeNode root) {
      if (root == null) return Integer.MIN_VALUE;
      return Math.max(
        root.data,
        Math.max(
          maxData(root.left),
          maxData(root.right)
        )
      );
    }
  }
