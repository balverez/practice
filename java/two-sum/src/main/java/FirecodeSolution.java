import java.util.HashMap;
import java.util.Map;

public class FirecodeSolution {
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
    Map<Integer, Integer> map = new HashMap<>();
    for (int i = 0; i < arr.length; i++) {
      int n = arr[i];
      if (map.containsKey(n)) {
        return new int[]{map.get(n), i};
      } else {
        map.put(target - n, i);
      }
    }

    return new int[]{};
  }
}