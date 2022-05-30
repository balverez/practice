namespace CloneGraph
{
    public class Solution
    {
        //O(n + m) time
        //O(n) space
        public Node? CloneGraph(Node? node)
        {
            if (node == null)
                return node;

            Queue<Node> nodes = new();
            nodes.Enqueue(node);

            Dictionary<int, Node> clones = new();
            clones.Add(node.val, new(node.val));
            
            Node iterator;
            while (nodes.Count > 0)
            {
                iterator = nodes.Dequeue();
                int key = iterator.val;

                foreach (Node neighbor in iterator.neighbors)
                {
                    if (!clones.ContainsKey(neighbor.val))
                    {
                        clones.Add(neighbor.val, new(neighbor.val));
                        nodes.Enqueue(neighbor);
                    }

                    clones[key].neighbors.Add(clones[neighbor.val]);
                }
            }

            return clones[node.val];
        }
    }
}