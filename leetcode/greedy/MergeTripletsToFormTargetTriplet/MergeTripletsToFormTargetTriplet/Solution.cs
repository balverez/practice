namespace MergeTripletsToFormTargetTriplet
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool MergeTriplets(int[][] triplets, int[] target)
        {
            bool[] valid = new bool[3];

            foreach (int[] t in triplets)
            {
                if (t[0] > target[0] || t[1] > target[1] || t[2] > target[2])
                    continue;

                for (int i = 0; i < 3; i++)
                    if (t[i] == target[i])
                        valid[i] = true;
            }


            return valid.All(v => v == true);
        }
    }
}