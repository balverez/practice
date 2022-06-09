namespace NumberOfConnectedComponentsInAnUndirectedGraph
{
    public class Solution
    {
        //O(e * alpha(v)) time
        //O(v) space
        public int CountComponents(int n, int[][] edges) => UnionFind(n, edges);

        private int UnionFind(int n, int[][] edges)
        {
            int[] parents = new int[n];
            int[] ranks = new int[n];

            for (int i = 0; i < n; i++)
            {
                parents[i] = i;
                ranks[i] = 1;
            }

            int components = n;
            foreach (int[] edge in edges)
                if (Union(edge[0], edge[1], parents, ranks))
                    components--;

            return components;
        }

        private bool Union(int n1, int n2, int[] parents, int[] ranks)
        {
            int p1 = FindParent(n1, parents);
            int p2 = FindParent(n2, parents);

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

        private int FindParent(int n, int[] parents)
        {
            int p = n;
            while (p != parents[p])
                p = parents[p];

            while (n != p)
            {
                int temp = parents[n];
                parents[n] = p;
                n = parents[temp];
            }

            return p;
        }

        //O(v + e) time
        //O(v + e) space
        private int DfsCount(int n, int[][] edges)
        {
            Dictionary<int, List<int>> adjacencyList = new();

            for (int i = 0; i < n; i++)
                adjacencyList[i] = new();

            foreach (int[] edge in edges)
            {
                adjacencyList[edge[0]].Add(edge[1]);
                adjacencyList[edge[1]].Add(edge[0]);
            }

            HashSet<int> visited = new();
            int components = 0;
            for (int i = 0; i < n; i++)
                if (!visited.Contains(i))
                {
                    components++;
                    Dfs(i, adjacencyList, visited);
                }

            return components;
        }

        private void Dfs(int u, Dictionary<int, List<int>> adjacencyList, HashSet<int> visited)
        {
            visited.Add(u);

            foreach (int v in adjacencyList[u])
                if (!visited.Contains(v))
                    Dfs(v, adjacencyList, visited);
        }
    }
}