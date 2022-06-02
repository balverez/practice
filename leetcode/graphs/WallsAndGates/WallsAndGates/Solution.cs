namespace WallsAndGates
{
    public class Solution
    {
        private const int WALL = -1;
        private const int GATE = 0;
        private const int EMPTY = int.MaxValue;

        public void WallsAndGates(int[][] rooms)
        {
            int m = rooms.Length;
            int n = rooms[0].Length;
            Queue<(int i, int j, int d)> queue = new();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (rooms[i][j] == GATE)
                        queue.Enqueue((i, j, GATE));

            int[] rowDirection = { -1, 1, 0, 0 };
            int[] columnDirection = { 0, 0, -1, 1 };
            while (queue.Count > 0)
            {
                (int i, int j, int d) = queue.Dequeue();
                int distance = d + 1;

                for (int direction = 0; direction < 4; direction++)
                {
                    int row = i + rowDirection[direction];
                    int column = j + columnDirection[direction];

                    if (row < 0 || row >= m || column < 0 || column >= n || rooms[row][column] == WALL || rooms[row][column] == GATE || rooms[row][column] <= distance)
                        continue;

                    rooms[row][column] = distance;
                    queue.Enqueue((row, column, distance));
                }
            }
        }
    }
}