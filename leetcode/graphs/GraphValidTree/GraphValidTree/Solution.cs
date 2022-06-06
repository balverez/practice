namespace GraphValidTree
{
    public class Solution
    {
        //O(n * alpha(n)) time
        //O(n) space
        public bool ValidTree(int n, int[][] edges)
        {
            if (n - 1 != edges.Length)
                return false;

            int[] parents = new int[n];
            int[] ranks = new int[n];

            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
                ranks[i] = 1;
            }

            foreach (int[] edge in edges)
                if (!Union(parents, ranks, edge[0], edge[1]))
                    return false;

            return true;
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
                ranks[p1] += ranks[p2];
            }
            else
            {
                parents[p1] = p2;
                ranks[p2] += ranks[p1];
            }

            return true;
        }

        private int FindParent(int[] parents, int n)
        {
            int p = n;
            while (p != parents[p])
            {
                parents[p] = parents[parents[p]];
                p = parents[p];
            }

            while (n != p)
            {
                int temp = parents[n];
                parents[n] = p;
                n = temp;
            }

            return p;
        }
    }
}