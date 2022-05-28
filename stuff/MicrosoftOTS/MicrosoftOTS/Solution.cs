using System;
using System.Collections.Generic;
using System.Linq;

namespace MicrosoftOTS
{
    // I misunderstood the problem statement the first go around. We aren't interested in the number of roads connected to a city,
    // we are interested in the number of unique roads connected to either city in a given pair.
    // I was able to find an instance of the question on LeetCode and cranked this out during lunch.
    internal class Solution
    {
        //O(n^2) time
        //O(n^2) space
        internal int MaximalNetworkRank(int[] A, int[] B, int N)
        {
            // We need to produce an Adjacency List to represent the undirected graph
            Dictionary<int, List<int>> vertexInDegrees = new Dictionary<int, List<int>>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!vertexInDegrees.ContainsKey(A[i]))
                    vertexInDegrees[A[i]] = new List<int>();

                if (!vertexInDegrees.ContainsKey(B[i]))
                    vertexInDegrees[B[i]] = new List<int>();
            }

            // Build out the associations between the cities in the array
            for (int i = 0; i < A.Length; i++)
            {
                if (!vertexInDegrees[A[i]].Contains(B[i]))
                    vertexInDegrees[A[i]].Add(B[i]);

                if (!vertexInDegrees[B[i]].Contains(A[i]))
                    vertexInDegrees[B[i]].Add(A[i]);
            }

            // I believe this operation is O(n^2) since we have to compare against each other city. 
            int maxRank = int.MinValue;
            int rank = 0;
            foreach (var city in vertexInDegrees)
            {
                foreach (var pair in vertexInDegrees.Where(v => v.Key != city.Key))
                {
                    // We can measure the degree of edges connected to a vertex pair by summing the total points
                    // adjacent to each vertex and subtracting one in case they share a road between each other.
                    rank = vertexInDegrees[city.Key].Count
                        + vertexInDegrees[pair.Key].Count
                        - (vertexInDegrees[city.Key].Contains(pair.Key) ? 1 : 0);
                    maxRank = Math.Max(maxRank, rank);
                }

            }

            return maxRank;
        }
    }
}