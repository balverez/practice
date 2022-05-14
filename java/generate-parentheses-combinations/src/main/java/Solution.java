import java.util.HashSet;
import java.util.Set;

public class Solution
{
    /**
     * Given n, generates and returns valid pairs
     * of parentheses.
     *
     * @param n Number of pairs of parentheses to generate.
     * @return Set containing valid combination strings.
     */
    public Set<String> generateParentheses(int n)
    {
        Set<String> result = new HashSet<>();
        buildParentheses(result, "", n, n);
        return result;
    }

    private void buildParentheses(Set<String> result, String str, int open, int close)
    {
        if (open <= close && open > 0)
        {
            buildParentheses(result, str + "(", open - 1, close);
        }
        if (open < close)
        {
            buildParentheses(result, str + ")", open, close - 1);
        }

        if (open == 0 && close == 0)
        {
            result.add(str);
        }
    }
}