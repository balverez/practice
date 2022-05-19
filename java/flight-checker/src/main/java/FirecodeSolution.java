import java.util.*;

public class FirecodeSolution {
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
    String destination
  ) {
    Set<String> visited = new HashSet<>();
    Queue<String> queue = new LinkedList<>();
    queue.offer(origin);
    while (!queue.isEmpty()) {
      String airportCode = queue.poll();
      if (airportCode.equals(destination)) return true;
      if (!visited.contains(airportCode)) {
        visited.add(airportCode);
        originDestinationsMap.getOrDefault(airportCode, List.of())
          .forEach(queue::offer);
      }
    }
    return false;
  }
}