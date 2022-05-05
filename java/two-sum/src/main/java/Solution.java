import java.util.HashMap;
import java.util.Map;

public class Solution {
    /**
     * Takes in an integer array and a target number and returns
     * an integer array containing indices of numbers that add up to
     * the target number.
     *
     * @param arr    Integer array.
     * @param target Integer target.
     * @return Indices of arr numbers which add up to the target number.
     */
    public static int[] twoSum(int[] arr, int target) {
        Map<Integer, Integer> map = new HashMap<Integer, Integer>(); 
        
        for (int i = 0; i < arr.length; i++)
        {
            if (map.get(arr[i]) != null)
            {
                return new int[] {map.get(arr[i]), i};
            }
            else
            {
                map.putIfAbsent(target - arr[i], i); 
            }
        }

        return new int[] { };
    }
}