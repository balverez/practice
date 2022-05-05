import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;
import java.util.SortedSet;
import java.util.TreeSet;

public class FirecodeSolution {
  /**
   * Returns duplicate integers in an array as a sorted array.
   *
   * @param arr Input array
   * @return Sorted array of duplicate items from the input
   */
  public int[] findDuplicateNumbers(int[] arr) {
    SortedSet<Integer> sortedSet = new TreeSet<>();
    Set<Integer> visitedSet = new HashSet<>();
    Arrays.stream(arr).forEach(n -> {
      if (visitedSet.contains(n)) sortedSet.add(n);
      visitedSet.add(n);
    });
    return sortedSet.stream().mapToInt(i -> i).toArray();
  }
}
