namespace LongestIncreasingSubsequence
{
    public class Solution
    {
        //O(nlogn)
        public int LengthOfLIS(int[] nums)
        {
            List<int> subsequence = new() { nums[0] };
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num > subsequence[subsequence.Count - 1])
                    subsequence.Add(num);
                else
                {
                    int j = BinarySearch(subsequence, num);
                    subsequence[j] = num;
                }
            }

            return subsequence.Count;
        }

        private int BinarySearch(List<int> subsequence, int num)
        {
            int l = 0;
            int r = subsequence.Count - 1;
            while (l <= r)
            {
                int p = (l + r) / 2;

                if (num == subsequence[p])
                    return p;

                if (num > subsequence[p])
                    l = p + 1;
                else
                    r = p - 1;
            }

            return l;
        }
    }
}