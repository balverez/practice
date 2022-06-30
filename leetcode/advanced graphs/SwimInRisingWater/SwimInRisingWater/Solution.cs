namespace SwimInRisingWater
{
    public class Solution
    {
        //O(mnlogmn) time, where m is the number of rows and n is the number of columns.
        //O(mn) space
        public int SwimInWater(int[][] grid)
        {
            int n = grid.Length;
            if (n == 1)
                return 0;

            PriorityQueue<(int, int, int), int> minHeap = new();
            int startpoint = grid[0][0];
            minHeap.Enqueue((startpoint, 0, 0), startpoint);
            int time = 0;
            int endpoint = grid[n - 1][n - 1];
            int[] rowDirection = { -1, 1, 0, 0 };
            int[] colDirection = { 0, 0, -1, 1 };
            HashSet<int> completed = new();

            //O(mnlogmn) time
            while (minHeap.Count > 0)
            {
                (int vertex, int i, int j) = minHeap.Dequeue();
                if (completed.Contains(vertex))
                    continue;

                time = Math.Max(time, vertex);
                if (vertex == endpoint)
                    break;

                completed.Add(vertex);
                //O(4) time
                for (int d = 0; d < 4; d++)
                {
                    int row = i + rowDirection[d];
                    int col = j + colDirection[d];
                    if (row < 0 || row >= n || col < 0 || col >= n)
                        continue;

                    int edge = grid[row][col];
                    if (!completed.Contains(edge))
                        minHeap.Enqueue((edge, row, col), edge);
                }
            }

            return time;
        }
    }
}