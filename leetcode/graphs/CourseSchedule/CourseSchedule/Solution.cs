using static CourseSchedule.Vertex;

namespace CourseSchedule
{
    public class Solution
    {
        //O(v + e) time
        //O(v + e) space
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, Vertex> vertices = new();
            Dictionary<int, List<int>> adjacencies = new();

            for (int i = 0; i < numCourses; i++)
            {
                vertices[i] = new(i);
                adjacencies[i] = new();
            }
            
            foreach (int[] req in prerequisites)
                adjacencies[req[0]].Add(req[1]);

            foreach (KeyValuePair<int, Vertex> mapping in vertices)
            {
                Vertex v = mapping.Value;
                if (v.State == Color.WHITE)
                    Dfs(v, vertices, adjacencies);
            }

            for (int i = 0; i < numCourses; i++)
                if (vertices[i].State == Color.GRAY)
                    return false;

            return true;
        }

        private void Dfs(Vertex u, Dictionary<int, Vertex> vertices, Dictionary<int, List<int>> adjacencies)
        {
            u.State = Color.GRAY;
            foreach (int neighborKey in adjacencies[u.Key])
            {
                Vertex v = vertices[neighborKey];
                if (v.State == Color.WHITE)
                {
                    Dfs(v, vertices, adjacencies);
                }
                if (v.State == Color.GRAY)
                    return;
            }

            u.State = Color.BLACK;
        }
    }
}