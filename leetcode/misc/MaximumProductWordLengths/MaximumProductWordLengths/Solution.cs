﻿namespace MaximumProductWordLengths
{
    public class Solution
    {
        //O(n^2 + l) time
        //O(n) space
        public int MaxProduct(string[] words)
        {
            int n = words.Length;
            int[] masks = new int[n];
            
            int bitmask;
            //O(n + l)
            for (int i = 0; i < n; i++)
            {
                bitmask = 0;
                foreach (char c in words[i])
                    bitmask |= 1 << (c - 'a');

                masks[i] = bitmask;
            }

            //O(n^2)
            int maxProduct = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if ((masks[i] & masks[j]) == 0)
                        maxProduct = Math.Max(maxProduct, words[i].Length * words[j].Length);

            return maxProduct;
        }
    }
}