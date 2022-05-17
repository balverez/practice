using System.Collections.Generic;

namespace AllPaths
{
    internal class Solution
    {
        internal HashSet<string> ReturnPaths(char[,] board)
        {
            HashSet<string> result = new();
            PathDfs(board, result, string.Empty, 0, 0);
            return result;
        }

        private void PathDfs(char[,] board, HashSet<string> paths, string str, int row, int column)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);

            if (row >= m || column >= n)
                return;

            str = str + board[row, column];
            if (row == m- 1 && column == n - 1)
            {
                paths.Add(str);
                return;
            }

            PathDfs(board, paths, str, row + 1, column);
            PathDfs(board, paths, str, row, column + 1);
        }
    }
}
