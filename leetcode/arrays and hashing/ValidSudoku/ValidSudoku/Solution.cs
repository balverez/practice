namespace ValidSudoku
{
    public class Solution
    {
        //O(n^2) time
        //O(n) space
        public bool IsValidSudoku(char[][] board)
        {
            int[] rowMasks = new int[9];
            int[] colMasks = new int[9];
            int[] boxMasks = new int[9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                        continue;

                    int n = board[i][j] - '1';

                    int box = (i / 3) * 3 + j / 3;
                    if (IsSet(rowMasks[i], n) || IsSet(colMasks[j], n) || IsSet(boxMasks[box], n))
                        return false;

                    rowMasks[i] |= 1 << n;
                    colMasks[j] |= 1 << n;
                    boxMasks[box] |= 1 << n;
                }
            }

            return true;
        }

        private bool IsSet(int bitmask, int n) => (bitmask & (1 << n)) != 0;
    }
}