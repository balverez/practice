/**
 * This class represents a node of a binary tree.
 * The `data` field holds the data value of this node,
 * and the `left` and `right` fields hold references
 * to the left and right child nodes, which are `null`
 * if this is a leaf node in a tree.
 */
public class TreeNode {
    int data; // Data as an Integer.
    TreeNode left; // Reference to the left node, can be null.
    TreeNode right; // Reference to the right node, can be null.

    /**
     * Constructor
     *
     * @param data  Integer data.
     * @param left  TreeNode referencing the left node, or null.
     * @param right TreeNode referencing the right node, or null.
     */
    TreeNode(int data, TreeNode left, TreeNode right) {
        this.data = data;
        this.left = left;
        this.right = right;
    }

    /**
     * Constructor that sets the left and right references to null,
     * creating a leaf node.
     *
     * @param data Integer data.
     */
    TreeNode(int data) {
        this(data, null, null);
    }
}
