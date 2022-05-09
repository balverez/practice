// public class FirecodeSolution {
//     /**
//      * Returns the number of ways to traverse a board of size m x n
//      * from the top left cell to its bottom right cell, using down
//      * and right directions of movement.
//      *
//      * @param m Number of rows of cells on the board.
//      * @param n Number of columns of cells on the board.
//      * @return Number of paths from the top left to bottom right.
//      */
//     public long countPaths(int m, int n) {
//       int[][] memo = new int[m][n];
//       for (int r = 0; r < m; r++) {
//         memo[r][0] = 1;
//       }
//       for (int c = 0; c < n; c++) {
//         memo[0][c] = 1;
//       }
  
//       for (int r = 1; r < m; r++) {
//         for (int c = 1; c < n; c++) {
//           memo[r][c] = memo[r - 1][c] + memo[r][c - 1];
//         }
//       }
  
//       return memo[m - 1][n - 1];
//     }
//   }