namespace NetworkDelayTime
{
    public class Solution
    {
        //O(V + ElogE) time
        //O(V + E) space
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            //O(V) space
            Dictionary<int, int> distances = new();
            //O(E) space
            Dictionary<int, List<(int, int)>> edges = new();

            //O(V) time
            for (int i = 1; i <= n; i++)
                distances[i] = int.MaxValue;
            
            distances[k] = 0;

            //O(E) time
            foreach (int[] edge in times)
            {
                int source = edge[0];
                if (!edges.ContainsKey(source))
                    edges[source] = new();

                edges[source].Add((edge[1], edge[2]));
            }

            //O(V) time
            //O(v) space
            PriorityQueue<int, int> minHeap = new();
            for (int i = 1; i <= n; i++)
                minHeap.Enqueue(i, distances[i]);

            int farthest = 0;
            HashSet<int> completed = new();
            while (minHeap.Count > 0)
            {
                int vertex = minHeap.Dequeue();
                if (completed.Contains(vertex))
                    continue;

                completed.Add(vertex);
                farthest = Math.Max(farthest, distances[vertex]);
                if (!edges.ContainsKey(vertex))
                    continue;

                foreach ((int edge, int weight) in edges[vertex])
                {
                    int distance = distances[vertex] + weight;
                    if (distances[edge] > distances[vertex] + weight)
                    {
                        distances[edge] = distance;
                        minHeap.Enqueue(edge, distance);
                    }
                }
                
            }

            return farthest == int.MaxValue ? -1 : farthest;
        }
    }
}