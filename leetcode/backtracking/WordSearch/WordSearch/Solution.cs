namespace WordSearch
{
    //O(mn * 3^k) time, where k is the length of the key.
    //O(k) space
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            int m = board.Length;
            int n = board[0].Length;
            char start = word[0];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (board[i][j].Equals(start) && Backtrack(board, word, 0, i, j, m, n))
                        return true;

            return false;
        }

        private bool Backtrack(char[][] board, string word, int i, int row, int col, int m, int n)
        {
            if (row < 0 || row >= m || col < 0 || col >= n || !board[row][col].Equals(word[i]))
                return false;

            if (i == word.Length - 1)
                return true;

            char c = board[row][col];
            board[row][col] = '0';
            i++;
            bool search = Backtrack(board, word, i, row - 1, col, m, n)
                || Backtrack(board, word, i, row + 1, col, m, n)
                || Backtrack(board, word, i, row, col - 1, m, n)
                || Backtrack(board, word, i, row, col + 1, m, n);

            board[row][col] = c;
            return search;
        }
    }
}