namespace RottingOranges
{
    public class Solution
    {
        private const int FRESH = 1;
        private const int ROTTEN = 2;

        //O(m * n) time
        //O(m * n) space
        public int OrangesRotting(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int freshOranges = 0;
            Queue<(int i, int j)> rottenOranges = new();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == FRESH)
                        freshOranges++;
                    else if (grid[i][j] == ROTTEN)
                        rottenOranges.Enqueue((i, j));
                }


            int minutes = 0;
            int[] rowDirections = { -1, 1, 0, 0 };
            int[] columnDirections = { 0, 0, -1, 1 };
            Queue<(int i, int j)> newRottenOranges = new();
            while (freshOranges > 0 && rottenOranges.Count > 0)
            {
                (int i, int j) = rottenOranges.Dequeue();

                for (int d = 0; d < 4; d++)
                {
                    int row = i + rowDirections[d];
                    int column = j + columnDirections[d];

                    if (row < 0 || row >= m || column < 0 || column >= n || grid[row][column] != FRESH)
                        continue;

                    freshOranges--;
                    grid[row][column] = ROTTEN;
                    newRottenOranges.Enqueue((row, column));
                }

                if (rottenOranges.Count == 0 && newRottenOranges.Count > 0)
                {
                    minutes++;
                    rottenOranges = new(newRottenOranges);
                    newRottenOranges = new();
                }
                else if (freshOranges == 0)
                    minutes++;
            }

            return freshOranges > 0 ? -1 : minutes;
        }
    }
}