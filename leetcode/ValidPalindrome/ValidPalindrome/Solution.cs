namespace ValidPalindrome
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l < r)
            {
                char lc = s[l];
                char rc = s[r];

                while (l < r && !IsAlphaNumeric(lc))
                {
                    l++;
                    lc = s[l];
                }

                while (l < r && !IsAlphaNumeric(rc))
                {
                    r--;
                    rc = s[r];
                }

                if (l < r && char.ToLower(lc) != char.ToLower(rc))
                    return false;

                l++;
                r--;
            }

            return true;
        }

        private bool IsAlphaNumeric(char c)
        {
            if ((c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                return true;

            return false;
        }
    }
}