import java.util.Deque;
import java.util.LinkedList;
import java.util.Map;

public class Solution
{
    /**
     * Checks if the input string of brackets is valid.
     *
     * @param str String containing bracket characters.
     * @return True if the string is valid.
     */
    public Boolean checkValid(String str)
    {
        Map<Character, Character> parenMap = Map.of('(', ')', '[', ']', '{', '}');
        Deque<Character> stack = new LinkedList<>();

        for (char c : str.toCharArray())
        {
            if (parenMap.containsKey(c))
            {
                stack.push(parenMap.get(c));
            }
            else if (stack.isEmpty() || (!stack.pop().equals(c)))
            {
                return false;
            }
        }

        return stack.isEmpty();
    }
}