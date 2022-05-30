﻿namespace CloneGraph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int val)
        {
            this.val = val;
            neighbors = new List<Node>();
        }

        public Node(int val, List<Node> neighbors)
        {
            this.val = val;
            this.neighbors = neighbors;
        }
    }
}