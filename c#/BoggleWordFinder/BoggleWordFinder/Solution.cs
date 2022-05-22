namespace BoggleWordFinder
{
    internal class Solution
    {
        //O(m * n * 4^k) time
        //O(n) space
        public bool FindWord(char[,] board, string word)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j].Equals(word[0]))
                    {
                        if (Dfs(board, word, i, j, 0))
                            return true;
                    }
                }

            return false;
        }

        private bool Dfs(char[,] board, string word, int i, int j, int k)
        {
            int m = board.GetLength(0);
            int n = board.GetLength(1);
            if (i < 0 || i >= m || j < 0 || j >= n || k >= word.Length || !board[i, j].Equals(word[k]))
                return false;

            if (k == word.Length - 1)
                return true;

            k++;
            return Dfs(board, word, i - 1, j, k)
                || Dfs(board, word, i + 1, j, k)
                || Dfs(board, word, i, j - 1, k)
                || Dfs(board, word, i, j + 1, k);
        }
    }
}