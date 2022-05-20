using System.Collections.Generic;
using System.Linq;

namespace BinaryTreeSerDe
{
    internal class Solution
    {
        internal TreeNode? SerDe(TreeNode? root) => Deserialize(Serialize(root));

        private string Serialize(TreeNode? root) => (root == null)
            ? "#"
            : $"{root.Data} {Serialize(root.Left)} {Serialize(root.Right)}";

        private TreeNode? Deserialize(string serialized)
        {
            List<TreeNode?> data = serialized.Split(' ')
                .Select(s => string.Equals(s, "#") ? null : new TreeNode(int.Parse(s)))
                .ToList();


            TreeNode? root = PreOrderDeserialization(data);

            return root;
        }

        private TreeNode? PreOrderDeserialization(List<TreeNode?> data)
        {
            TreeNode? node = data[0];
            data.RemoveAt(0);

            if (node != null)
            {
                node.Left = PreOrderDeserialization(data);
                node.Right = PreOrderDeserialization(data);
            }

            return node;
        }
    }
}