public class Solution {
    /**
     * Returns the nth Fibonacci number in linear time and
     * with constant space.
     *
     * @param n Which number to return in the sequence.
     * @return Nth Fibonacci number.
     */
    public long betterFibonacci(int n) {
      if (n < 1) {
        return 0;
      }
      if (n < 2)
      {
        return 1;
      }
      
      long fibonacci = Integer.MIN_VALUE;
      long first = 0;
      long second = 1;
      
      for (int i = 1; i < n; i++)
      {
        fibonacci = first + second;
        first = second;
        second = fibonacci;
      }
      
      return fibonacci;
    }
  }