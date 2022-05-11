using System.Linq;

namespace CsvDelimiter
{
    public class Solution
    {
        public string? replaceCsvDelimiter(string csv, string replacement)
        {
            return string.Join(string.Empty, csv.Select(c => char.Equals(c, ',') ? replacement : c.ToString()));
        }
    }
}
