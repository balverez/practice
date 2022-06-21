namespace ReconstructItinerary
{
    public class Solution
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, List<string>> adjList = new();
            foreach (List<string> ticket in tickets.OrderBy(t => t[1]))
            {
                string key = ticket[0];
                if (!adjList.ContainsKey(key))
                    adjList[key] = new();

                adjList[key].Add(ticket[1]);
            }

            List<string> result = new();
            Backtrack(adjList, ref result, new() { "JFK" }, tickets.Count + 1);

            return result;
        }

        private void Backtrack(Dictionary<string, List<string>> adjList, ref List<string> result, List<string> current, int target)
        {
            if (result.Count > 0)
                return;
            if (current.Count == target)
            {
                result = new(current);
                return;
            }
            string source = current.Last();

            if (!adjList.ContainsKey(source))
                return;

            List<string> destinations = new(adjList[source]);
            foreach (string destination in destinations)
            {
                current.Add(destination);
                adjList[source].RemoveAt(0);
                Backtrack(adjList, ref result, current, target);
                current.RemoveAt(current.Count - 1);
                adjList[source].Add(destination);
            }
        }
    }
}