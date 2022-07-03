namespace LargestRectangleInHistogram
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 1)
                return heights[0];

            Stack<(int, int)> stack = new();
            stack.Push((-1, -1));
            int max = int.MinValue;
            for (int j = 0; j < heights.Length; j++)
            {
                int k = j;
                while (stack.Count > 1 && heights[j] < stack.Peek().Item1)
                {
                    (int height, int i) = stack.Pop();
                    k = i;
                    max = Math.Max(max, height * (j - i));
                }

                stack.Push((heights[j], k));
            }

            while (stack.Count > 1)
            {
                (int height, int i) = stack.Pop();
                max = Math.Max(max, height * (heights.Length - i));
            }

            return max;
        }
    }
}