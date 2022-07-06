namespace WordSearchII
{
    public class Solution
    {
        //O(mn * (4*(3^k))) time, where m represents the number of rows, n representts the number of columns, and k represents the number of words.
        //O(k) space.
        public IList<string> FindWords(char[][] board, string[] words)
        {
            Trie trie = new();
            foreach (string word in words)
                trie.Add(word);

            List<string> found = new();
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                    if (trie.Root.Children.ContainsKey(board[i][j]))
                        Backtrack(board, found, i, j, trie.Root);

            return found;
        }

        private static void Backtrack(char[][] board, List<string> found, int i, int j, TrieNode parent)
        {
            char c = board[i][j];
            TrieNode prefix = parent.Children[c];
            if (prefix.Word != null)
            {
                found.Add(prefix.Word);
                prefix.Word = null;
            }

            if (prefix.Children.Count > 0)
            {
                board[i][j] = '*';
                DFS(board, found, i, j, prefix);
                board[i][j] = c;
            }

            if (prefix.Children.Count == 0)
                parent.Children.Remove(c);
        }

        private static void DFS(char[][] board, List<string> found, int i, int j, TrieNode prefix)
        {
            int m = board.Length;
            int n = board[0].Length;
            int[] rowDir = { -1, 1, 0, 0 };
            int[] colDir = { 0, 0, -1, 1 };
            for (int d = 0; d < 4; d++)
            {
                int row = i + rowDir[d];
                int col = j + colDir[d];

                if (row < 0 || row >= m || col < 0 || col >= n)
                    continue;

                if (prefix.Children.ContainsKey(board[row][col]))
                    Backtrack(board, found, row, col, prefix);
            }
        }
    }
}