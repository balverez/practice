namespace SerializeDeserializeBinaryTree
{
    public class Codec
    {
        //O(n) time
        //O(n) space
        public string serialize(TreeNode? root)
        {
            if (root == null)
                return string.Empty;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            string data = $"{root.val}";
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                data += 
                    $" {(node.left != null ? node.left.val : "#")} " +
                    $"{(node.right != null ? node.right.val : "#")}";

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            return data;
        }

        //O(n) time
        //O(n) space
        public TreeNode? deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;

            string[] dataArr = data.Split(" ");
            int i = 0;
            TreeNode root = new(int.Parse(dataArr[i++]));
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (i < dataArr.Length)
                {
                    node.left = dataArr[i] != "#" ? new(int.Parse(dataArr[i])) : null;
                    i++;
                }

                if (i < dataArr.Length)
                {
                    node.right = dataArr[i] != "#" ? new(int.Parse(dataArr[i])) : null;
                    i++;
                }

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            return root;
        }
    }
}