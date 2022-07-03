namespace MultiplyStrings
{
    public class Solution
    {
        //O(mn) time
        //O(m + n) space 
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            num1 = string.Join(string.Empty, num1.Reverse());
            num2 = string.Join(string.Empty, num2.Reverse());
            int[] product = new int[num1.Length + num2.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    int digit = (num1[i] - '0') * (num2[j] - '0');
                    int place = i + j;
                    product[place] += digit;
                    product[place + 1] += product[place] / 10;
                    product[place] = product[place] % 10;
                }
            }

            int lz = 0;
            Array.Reverse(product);
            while (lz < product.Length && product[lz] == 0)
                lz++;

            return string.Join(string.Empty, product[lz..]);
        }
    }
}