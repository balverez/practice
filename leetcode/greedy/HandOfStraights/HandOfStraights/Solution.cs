namespace HandOfStraights
{
    public class Solution
    {
        //O(nlogn) time
        //O(n) space
        public bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0)
                return false;

            Dictionary<int, int> instances = new();

            foreach (int i in hand)
                instances[i] = instances.GetValueOrDefault(i, 0) + 1;

            PriorityQueue<int, int> minHeap = new();
            foreach (int key in instances.Keys)
                minHeap.Enqueue(key, key);

            while (minHeap.Count > 0)
            {
                int first = minHeap.Peek();

                for (int i = first; i < first + groupSize; i++)
                {
                    if (!instances.ContainsKey(i))
                        return false;

                    if (--instances[i] == 0)
                    {
                        if (i != minHeap.Peek())
                            return false;

                        minHeap.Dequeue();
                    }
                }
            }

            return true;
        }
    }
}