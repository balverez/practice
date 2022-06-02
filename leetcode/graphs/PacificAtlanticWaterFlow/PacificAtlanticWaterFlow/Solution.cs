namespace PacificAtlanticWaterFlow
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            List<IList<int>> result = new();
            int m = heights.Length;
            int n = heights[0].Length;

            Queue<int[]> pacificBorder = new();
            Queue<int[]> atlanticBorder = new();

            for (int i = 0; i < m; i++)
            {
                pacificBorder.Enqueue(new int[] { i, 0 });
                atlanticBorder.Enqueue(new int[] { i, n - 1 });
            }

            for (int j = 0; j < n; j++)
            {
                pacificBorder.Enqueue(new int[] { 0, j });
                atlanticBorder.Enqueue(new int[] { m - 1, j });
            }

            bool[,] pacificReaches = IterativeBfs(pacificBorder, heights, m, n);
            bool[,] atlanticReaches = IterativeBfs(atlanticBorder, heights, m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (pacificReaches[i, j] && atlanticReaches[i, j])
                        result.Add(new List<int>() { i, j });

            return result;
        }

        private bool[,] IterativeBfs(Queue<int[]> queue, int[][] heights, int m, int n)
        {
            bool[,] reaches = new bool[m, n];
            int[] rowDirection = { -1, 1, 0, 0 };
            int[] columnDirection = { 0, 0, -1, 1 };

            int[] node;
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                int i = node[0];
                int j = node[1];
                reaches[i, j] = true;

                for (int d = 0; d < 4; d++)
                {
                    int row = i + rowDirection[d];
                    int column = j + columnDirection[d];

                    if (row < 0
                        || row >= m
                        || column < 0
                        || column >= n
                        || reaches[row, column]
                        || heights[row][column] < heights[i][j])
                        continue;

                    queue.Enqueue(new int[] { row, column });
                }
            }

            return reaches;
        }
    }
}