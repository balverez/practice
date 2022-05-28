namespace RecoverIpAddresses
{
    internal class Solution
    {
        internal HashSet<string> GenerateIpAddresses(string input)
        {
            HashSet<string> ipAddresses = new();
            BuildDfs(input, string.Empty, 0, 3, ipAddresses);
            return ipAddresses;
        }

        private void BuildDfs(string input, string address, int i, int dots, HashSet<string> ipAddresses)
        {
            if (i > input.Length || dots < 0)
                return;
            else if (dots == 0 && i == input.Length)
                ipAddresses.Add(address);

            for (int j = 1; j < 4; j++)
            {
                if (i + j <= input.Length && IsValidByte(input[i..(i + j)]))
                {
                    string s = input[i..(i + j)];
                    string possibleAddress = string.IsNullOrEmpty(address) ? s : string.Join('.', address, s);
                    int remainingDots = string.IsNullOrEmpty(address) ? dots : dots - 1;
                    BuildDfs(input, possibleAddress, i + s.Length, remainingDots, ipAddresses);
                }

            }
        }

        private bool IsValidByte(string input)
        {
            int parsedInt = int.Parse(input);
            return !(input.Length > 1 && input[0] == '0') && parsedInt >= 0 && parsedInt <= 255;
        }
    }
}