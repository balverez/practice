namespace CountGoodNodesInBinaryTree
{
    //O(n) time
    //O(n) space
    public class Solution
    {
        public int GoodNodes(TreeNode root)
        {
            int count = 0;
            Queue<(TreeNode, int)> nodes = new();
            nodes.Enqueue((root, int.MinValue));
            while (nodes.Count > 0)
            {
                (TreeNode node, int pathMax) = nodes.Dequeue();
                if (node.val >= pathMax)
                {
                    count++;
                    pathMax = node.val;
                }

                if (node.left != null)
                    nodes.Enqueue((node.left, pathMax));
                if (node.right != null)
                    nodes.Enqueue((node.right, pathMax));
            }

            return count;
        }
    }
}