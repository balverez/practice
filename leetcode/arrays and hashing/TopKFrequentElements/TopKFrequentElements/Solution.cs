namespace TopKFrequentElements
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new();
            foreach (int i in nums)
                map[i] = map.GetValueOrDefault(i, 0) + 1;

            List<int>[] buckets = new List<int>[nums.Length + 1];
            foreach (int key in map.Keys)
            {
                int bucket = map[key];
                if (buckets[bucket] == null)
                    buckets[bucket] = new();

                buckets[bucket].Add(key);
            }

            List<int> result = new();
            for (int i = buckets.Length - 1; i >= 0; i--)
            {
                if (buckets[i] != null)
                {
                    foreach (int key in buckets[i])
                    {
                        result.Add(key);

                        if (result.Count == k)
                            return result.ToArray();
                    }
                }
            }

            return Array.Empty<int>();
        }
    }
}