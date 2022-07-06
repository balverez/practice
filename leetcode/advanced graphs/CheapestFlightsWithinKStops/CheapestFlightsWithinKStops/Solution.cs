namespace CheapestFlightsWithinKStops
{
    public class Solution
    {
        //O(V + ElogE) time
        //O(V + E) space
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[] distances = new int[n];
            int[] stops = new int[n];
            Dictionary<int, List<(int, int)>> adjList = new();
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue;
                stops[i] = int.MaxValue;
                adjList[i] = new();
            }
            distances[src] = 0;
            stops[src] = 0;

            foreach (int[] flight in flights)
                adjList[flight[0]].Add((flight[1], flight[2]));

            PriorityQueue<(int, int, int), int> minHeap = new();
            minHeap.Enqueue((src, 0, 0), 0);
            while (minHeap.Count > 0)
            {
                (int airport, int cost, int currentStops) = minHeap.Dequeue();
                if (airport == dst)
                    return cost;

                if (currentStops == k + 1)
                    continue;

                foreach ((int adj, int weight) in adjList[airport])
                {
                    int distance = cost + weight;
                    if (distance < distances[adj])
                    {
                        minHeap.Enqueue((adj, distance, currentStops + 1), distance);
                        distances[adj] = distance;
                        stops[adj] = currentStops;
                    }
                    else if (currentStops < stops[adj])
                        minHeap.Enqueue((adj, distance, currentStops + 1), distance);
                }
            }

            return distances[dst] == int.MaxValue ? -1 : distances[dst];
        }
    }
}