import java.util.*;

public class Solution {
  /**
   * Takes in origin -> destination graph as
   * an adjacency list, an origin and a destination
   * and checks if a route is possible from the origin
   * to the destination.
   *
   * @param originDestinationsMap Graph as adjacency list.
   * @param origin                Origin airport code.
   * @param destination           Destination airport code.
   * @return True if a non-stop or connecting route exists.
   */
  public Boolean flightCheck(
    Map<String, List<String>> originDestinationsMap,
    String origin,
    String destination)
    {
      Set<String> visited = new HashSet<String>();
      Deque<String> queue = new LinkedList<>();
      queue.offer(origin);
      
      String airport;
      while (!queue.isEmpty()) {
        airport = queue.poll();
        
        if (airport.equals(destination)) {
          return true;
        }
        
        if (!visited.contains(airport)) {
          visited.add(airport);
          
          List<String> nonstops = originDestinationsMap.getOrDefault(airport, List.of());
          
          for (String nonstop : nonstops)
          {
            if (!visited.contains(nonstop)) {
              queue.offer(nonstop);
            }
          }
        }
      }
      
      return false;
    }
}