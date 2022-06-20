namespace TopKFrequentElements
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> instances = new();
            foreach (int i in nums)
                instances[i] = instances.GetValueOrDefault(i, 0) + 1;

            List<int>[] buckets = new List<int>[nums.Length + 1];

            foreach (int key in instances.Keys)
            {
                if (buckets[instances[key]] == null)
                    buckets[instances[key]] = new();

                buckets[instances[key]].Add(key);
            }

            List<int> result = new();
            for (int i = buckets.Length - 1; i >= 0; i--)
                if (buckets[i] != null)
                    foreach (int element in buckets[i])
                    {
                        result.Add(element);

                        if (result.Count == k)
                            return result.ToArray();
                    }

            return Array.Empty<int>();
        }
    }
}