using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
            .Select((row, i) => new { sum = row.Sum(), i = i })
            .OrderBy(row => row.sum)
            .ThenBy(row => row.i)
            .Select(row => row.i)
            .Take(k)
            .ToArray();
    }
}