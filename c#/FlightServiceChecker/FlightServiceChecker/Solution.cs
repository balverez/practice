using System.Collections.Generic;
using System.Linq;

namespace FlightServiceChecker
{
    internal class Solution
    {
        public bool FlightCheck(Dictionary<string, List<string>> originDestinationsMap, string origin, string destination)
        {
            HashSet<string> visited = new();
            Queue<string> queue = new();
            queue.Enqueue(origin);

            string airport;
            while (queue.Count > 0)
            {
                airport = queue.Dequeue();
                if (string.Equals(airport, destination))
                    return true;

                if (!visited.Contains(airport))
                {
                    visited.Add(airport);

                    List<string>? nonstops = originDestinationsMap.GetValueOrDefault(airport) ?? new();
                    foreach (string nonstop in nonstops)
                    {
                        if (!visited.Contains(nonstop))
                            queue.Enqueue(nonstop);
                    }
                }
            }

            return false;
        }
    }
}