namespace SurroundedRegions
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public void Solve(char[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;

            Queue<int[]> borderAreas = new();
            for (int i = 0; i < m; i++)
            {
                if (board[i][0] == 'O')
                    borderAreas.Enqueue(new int[] { i, 0 });
                if (board[i][n - 1] == 'O')
                    borderAreas.Enqueue(new int[] { i, n - 1 });
            }

            for (int j = 0; j < n; j++)
            {
                if (board[0][j] == 'O')
                    borderAreas.Enqueue(new int[] { 0, j });
                if (board[m - 1][j] == 'O')
                    borderAreas.Enqueue(new int[] { m - 1, j });
            }

            bool[,] borderRegions = IterativeBfs(borderAreas, board, m, n);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (board[i][j] == 'O' && !borderRegions[i, j])
                        board[i][j] = 'X';
        }

        private bool[,] IterativeBfs(Queue<int[]> borderAreas, char[][] board, int m, int n)
        {
            bool[,] borderRegions = new bool[m, n];
            int[] rowDirection = { -1, 1, 0, 0 };
            int[] columnDirection = { 0, 0, -1, 1 };
            HashSet<string> visited = new();

            int[] node;
            while (borderAreas.Count > 0)
            {
                node = borderAreas.Dequeue();
                int i = node[0];
                int j = node[1];
                borderRegions[i, j] = true;
                visited.Add($"[{i}, {j}]");

                for (int d = 0; d < 4; d++)
                {
                    int row = i + rowDirection[d];
                    int column = j + columnDirection[d];

                    if (row < 0
                        || row >= m
                        || column < 0
                        || column >= n
                        || board[row][column] == 'X'
                        || visited.Contains($"[{row}, {column}]"))
                        continue;

                    borderAreas.Enqueue(new int[] { row, column });
                }
            }

            return borderRegions;
        }
    }
}