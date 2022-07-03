namespace MedianOfTwoSortedArrays
{
    public class Solution
    {
        //O(log(min(m, n))) time
        //O(1) space
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                (nums1, nums2) = (nums2, nums1);

            int m = nums1.Length;
            int n = nums2.Length;
            int partition = (m + n) / 2;
            int l = 0;
            int r = n;
            while (l <= r)
            {
                int mp = (l + r) / 2;
                int np = partition - mp;
                int l1 = mp == 0 ? int.MinValue : nums1[mp - 1];
                int l2 = np == 0 ? int.MinValue : nums2[np - 1];
                int r1 = mp == m ? int.MaxValue : nums1[mp];
                int r2 = np == n ? int.MaxValue : nums2[np];

                if (l1 > r2)
                    r = mp - 1;
                else if (l2 > r1)
                    l = mp + 1;
                else
                    return (m + n) % 2 == 0
                        ? ((double)(Math.Max(l1, l2) + Math.Min(r1, r2)) / 2)
                        : Math.Min(r1, r2);
            }

            return -1;
        }
    }
}