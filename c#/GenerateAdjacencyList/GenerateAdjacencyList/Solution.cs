using System.Collections.Generic;

namespace GenerateAdjacencyList
{
    internal class Solution
    {
        internal Dictionary<string, List<string>> GraphAdjacencyList(List<List<string>> originDestinations)
        {
            Dictionary<string, List<string>> adjacencyList = new();

            foreach (List<string> route in originDestinations)
            {
                if (!adjacencyList.ContainsKey(route[0]))
                    adjacencyList[route[0]] = new();

                if (!adjacencyList[route[0]].Contains(route[1]))
                    adjacencyList[route[0]].Add(route[1]);
            }

            return adjacencyList;
        }
    }
}