namespace CourseScheduleII
{
    public class Solution
    {
        //O(v + e) time
        //O(v + e) space
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> adjList = new();
            for (int i = 0; i < numCourses; i++)
            {
                adjList[i] = new();
            }

            foreach (int[] prereq in prerequisites)
                adjList[prereq[0]].Add(prereq[1]);

            Dictionary<int, bool> visited = new();
            List<int> topSort = new();
            for (int i = 0; i < numCourses; i++)
                if (!Dfs(topSort, adjList, visited, i))
                    return Array.Empty<int>();

            return topSort.ToArray();
        }

        private bool Dfs(List<int> topSort, Dictionary<int, List<int>> adjList, Dictionary<int, bool> visited, int node)
        {
            if (visited.ContainsKey(node))
                return visited[node];

            visited[node] = false;
            foreach (int neighbor in adjList[node])
                if (!Dfs(topSort, adjList, visited, neighbor))
                    return false;

            visited[node] = true;
            topSort.Add(node);
            return true;
        }
    }
}