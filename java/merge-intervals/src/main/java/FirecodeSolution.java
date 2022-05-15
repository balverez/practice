import java.util.Comparator;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Takes a list of intervals, merges overlapping intervals
   * and returns a new list of merged intervals.
   *
   * @param intervals Input list of intervals.
   * @return List of overlapped intervals merged.
   */
  public List<List<Integer>> mergeIntervals(List<List<Integer>> intervals) {
    List<List<Integer>> sortedIntervals =
      intervals
        .stream()
        .sorted(Comparator.comparingInt(i -> i.get(0)))
        .collect(Collectors.toList());

    LinkedList<List<Integer>> merged = new LinkedList<>();

    for (List<Integer> interval : sortedIntervals) {
      if (merged.isEmpty() || merged.getLast().get(1) < interval.get(0)) {
        merged.add(interval);
      } else {
        merged.getLast().set(1, Math.max(merged.getLast().get(1), interval.get(1)));
      }
    }
    return merged;
  }
}