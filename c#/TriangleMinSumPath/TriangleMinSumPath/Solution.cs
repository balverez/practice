using System;
using System.Collections.Generic;

namespace TriangleMinSumPath
{
    internal class Solution
    {
        internal int TriangleMinPathSum(List<List<int>> triangle)
        {
            int levels = triangle.Count;

            int[] memo = new int[levels];

            for (int i = 0; i < triangle[levels - 1].Count; i++)
                memo[i] = triangle[levels - 1][i];

            for (int i = levels - 2; i >= 0; i--)
                for (int j = 0; j < triangle[i].Count; j++)
                    memo[j] = triangle[i][j] + Math.Min(memo[j], memo[j + 1]);

            return memo[0];
        }
    }
}