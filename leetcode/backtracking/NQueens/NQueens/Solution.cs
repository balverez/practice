using System.Text;

namespace NQueens
{
    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> result = new();
            HashSet<(int, int)> board = new();
            Backtrack(result, board, n, 0);

            return result;
        }

        //O(n!) time
        //O(n) space
        private void Backtrack(List<IList<string>> result, HashSet<(int, int)> board, int n, int start)
        {
            if (start == n)
            {
                List<string> newBoard = new();
                for (int i = 0; i < n; i++)
                {
                    StringBuilder row = new(string.Empty);
                    for (int j = 0; j < n; j++)
                        row.Append(board.Contains((i, j)) ? 'Q' : '.');

                    newBoard.Add(row.ToString());
                }

                result.Add(newBoard);
            }

            for (int j = 0; j < n; j++)
            {
                if (Check(board, start, j))
                {
                    board.Add((start, j));
                    Backtrack(result, board, n, start + 1);
                    board.Remove((start, j));
                }
            }
        }

        private bool Check(HashSet<(int, int)> board, int i, int j)
        {
            foreach ((int x, int y) in board)
            {
                if (i == x && j == y)
                    continue;

                if (Math.Abs(i - x) == Math.Abs(j - y) || j == y)
                    return false;
            }

            return true;
        }
    }
}