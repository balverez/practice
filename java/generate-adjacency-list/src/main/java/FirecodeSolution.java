import java.util.*;
import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Takes in a nested list of origin, destination pairs and
   * returns an adjacency list containing mappings of
   * origin -> list of non-stop destinations reachable from the origin.
   *
   * @param originDestinations Nested list of origin, destination pairs.
   * @return Graph as adjacency list.
   */
  public Map<String, List<String>> graphAdjacencyList(
    List<List<String>> originDestinations
  ) {
    Map<String, Set<String>> adjacencySet = new HashMap<>();

    originDestinations.forEach(pair -> {
      adjacencySet.putIfAbsent(pair.get(0), new HashSet<>());
      adjacencySet.get(pair.get(0)).add(pair.get(1));
    });

    return adjacencySet
             .entrySet()
             .stream()
             .map(entry -> Map.entry(
               entry.getKey(), new ArrayList<>(entry.getValue()))
             )
             .collect(Collectors.toMap(Map.Entry::getKey, Map.Entry::getValue));
  }
}