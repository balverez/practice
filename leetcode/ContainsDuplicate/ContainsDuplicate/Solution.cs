namespace ContainsDuplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();

            foreach (int i in nums)
            {
                if (set.Contains(i))
                    return true;

                set.Add(i);
            }

            return false;
        }
    }
}