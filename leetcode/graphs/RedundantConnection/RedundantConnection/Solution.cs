namespace RedundantConnection
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int[] FindRedundantConnection(int[][] edges)
        {
            int[] parents = new int[edges.Length + 1];
            int[] ranks = new int[edges.Length + 1];

            for (int i = 1; i <= edges.Length; i++)
            {
                parents[i] = i;
                ranks[i] = 1;
            }

            foreach (int[] edge in edges)
                if (!Union(parents, ranks, edge[0], edge[1]))
                    return edge;

            return Array.Empty<int>();
        }

        private int FindParent(int[] parents, int n)
        {
            int parent = n;
            while (parent != parents[parent])
            {
                parents[parent] = parents[parents[parent]];
                parent = parents[parent];
            }

            return parent;
        }

        private bool Union(int[] parents, int[] ranks, int n1, int n2)
        {
            int p1 = FindParent(parents, n1);
            int p2 = FindParent(parents, n2);

            if (p1 == p2)
                return false;
            
            if (ranks[p1] >= ranks[p2])
            {
                parents[p2] = p1;
                ranks[p1]++;
            }
            else
            {
                parents[p1] = p2;
                ranks[p2]++;
            }

            return true;
        }
    }
}