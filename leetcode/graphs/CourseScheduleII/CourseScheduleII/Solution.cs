namespace CourseScheduleII
{
    public class Solution
    {
        //O(v + e) time
        //O(v + e) space
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, Vertex> vertices = new();
            for (int i = 0; i < numCourses; i++)
            {
                vertices[i] = new(i);
            }

            foreach (int[] prerequisite in prerequisites)
                vertices[prerequisite[0]].Requirements.Add(vertices[prerequisite[1]]);

            List<Vertex> topologicalSorting = new();
            int time = 0;
            for (int i = 0; i < numCourses; i++)
            {
                Vertex u = vertices[i];
                if (u.State == Vertex.Color.WHITE)
                    Dfs(topologicalSorting, u, ref time);
            }

            for (int i = 0; i < numCourses; i++)
                if (vertices[i].State == Vertex.Color.GRAY)
                    return Array.Empty<int>();

            return topologicalSorting.Select(vertex => vertex.Key).ToArray();
        }

        private void Dfs(List<Vertex> topologicalSorting, Vertex u, ref int time)
        {
            u.State = Vertex.Color.GRAY;
            foreach (Vertex v in u.Requirements)
            {
                if (v.State == Vertex.Color.WHITE)
                    Dfs(topologicalSorting, v, ref time);
                if (v.State == Vertex.Color.GRAY)
                    return;
            }

            u.State = Vertex.Color.BLACK;
            topologicalSorting.Add(u);
        }
    }
}