import java.util.*;

public class Solution {
    /**
     * Returns duplicate integers in an array as a sorted array.
     *
     * @param arr Input array
     * @return Sorted array of duplicate items from the input
     */
    public int[] findDuplicateNumbers(int[] arr) {
        SortedSet<Integer> sortedSet = new TreeSet<>();
        Set<Integer> visitedSet = new HashSet<>();
        Arrays.stream(arr).forEach(n ->
        {
            if (visitedSet.contains(n))
            {
                sortedSet.add(n);
            }

            visitedSet.add(n);
        });

        return sortedSet.stream().mapToInt(n -> n).toArray();
    }
}
