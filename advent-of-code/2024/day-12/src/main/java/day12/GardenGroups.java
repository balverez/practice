package day12;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class GardenGroups {
    private static final char[] NAV_ARRAY = { '^', '>', 'v', '<' };

    private final int colCount;

    private final int rowCount;

    private final char[][] matrix;

    public GardenGroups(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            List<String> lines = new ArrayList<>();
            while (scanner.hasNextLine())
                lines.add(scanner.nextLine());

            colCount = lines.getFirst().length();
            rowCount = lines.size();
            matrix = new char[rowCount][colCount];

            IntStream.range(0, rowCount).forEach(i ->
                    matrix[i] = Arrays.copyOf(lines.get(i).toCharArray(), colCount));
        }
    }

    public Long fencingCost() {
        Map<Character, Set<Set<String>>> regionMap = mapRegions();

        return calculateCost(regionMap);
    }

    public Long fencingCostWithBulkDiscount() {
        Map<Character, Set<Set<String>>> regionMap = mapRegions();

        return calculateCostWithBulkDiscount(regionMap);
    }

    private Long calculateCost(Map<Character, Set<Set<String>>> regionMap) {
        long totalCost = 0L;
        for (Map.Entry<Character, Set<Set<String>>> entry : regionMap.entrySet()) {
            Character key = entry.getKey();
            for (Set<String> region : entry.getValue()) {
                Long perimeter = 0L;
                for (String area : region)
                    perimeter += determinePerimeter(key, area, new HashMap<>());

                totalCost += region.size() * perimeter;
            }
        }

        return totalCost;
    }

    private Long calculateCostWithBulkDiscount(Map<Character, Set<Set<String>>> regionMap) {
        long totalCost = 0L;
        for (Map.Entry<Character, Set<Set<String>>> regionEntry : regionMap.entrySet()) {
            Character key = regionEntry.getKey();
            for (Set<String> region : regionEntry.getValue()) {
                Map<Character, Set<String>> sideMap = new HashMap<>();
                for (String area : region)
                    determinePerimeter(key, area, sideMap);

                totalCost += region.size() * determineSides(sideMap);
            }
        }

        return totalCost;
    }

    private Long determinePerimeter(Character key, String area, Map<Character, Set<String>> sideMap) {
        int perimeter = 0;
        String[] coordinates = area.split(",");
        int i = Integer.parseInt(coordinates[0]);
        int j = Integer.parseInt(coordinates[1]);
        if (i - 1 < 0 || matrix[i - 1][j] != key) {
            if (!sideMap.containsKey(NAV_ARRAY[0]))
                sideMap.put(NAV_ARRAY[0], new HashSet<>());

            sideMap.get(NAV_ARRAY[0]).add(area);
            perimeter++;
        }

        if (j + 1 >= colCount || matrix[i][j + 1] != key) {
            if (!sideMap.containsKey(NAV_ARRAY[1]))
                sideMap.put(NAV_ARRAY[1], new HashSet<>());

            sideMap.get(NAV_ARRAY[1]).add(area);
            perimeter++;
        }

        if (i + 1 >= rowCount || matrix[i + 1][j] != key) {
            if (!sideMap.containsKey(NAV_ARRAY[2]))
                sideMap.put(NAV_ARRAY[2], new HashSet<>());

            sideMap.get(NAV_ARRAY[2]).add(area);
            perimeter++;
        }

        if (j - 1 < 0 || matrix[i][j - 1] != key) {
            if (!sideMap.containsKey(NAV_ARRAY[3]))
                sideMap.put(NAV_ARRAY[3], new HashSet<>());

            sideMap.get(NAV_ARRAY[3]).add(area);
            perimeter++;
        }

        return (long) perimeter;
    }

    private Map<Character, Set<Set<String>>> mapRegions() {
        Map<Character, Set<Set<String>>> regionMap = new HashMap<>();
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                Set<String> regionSet = new HashSet<>();
                String key = i + "," + j;
                if (regionMap.containsKey(matrix[i][j])) {
                    if (regionMap.get(matrix[i][j]).stream().anyMatch(set -> set.contains(key)))
                        continue;
                    else
                        regionMap.get(matrix[i][j]).add(regionSet);
                } else {
                    regionMap.put(matrix[i][j], new HashSet<>());
                    regionMap.get(matrix[i][j]).add(regionSet);
                }

                plotRegion(i, j, matrix[i][j], regionMap, regionSet);
            }
        }

        return regionMap;
    }

    private void plotRegion(
            int i,
            int j,
            Character regionKey,
            Map<Character, Set<Set<String>>> regionMap,
            Set<String> regionSet) {
        if (i > -1
                && i < rowCount
                && j > -1
                && j < colCount
                && matrix[i][j] == regionKey
                && regionMap.get(matrix[i][j]).stream().noneMatch(set -> set.contains(i + "," + j))) {

            regionSet.add(i + "," + j);
            plotRegion(i - 1, j, regionKey, regionMap, regionSet);
            plotRegion(i, j + 1, regionKey, regionMap, regionSet);
            plotRegion(i + 1, j, regionKey, regionMap, regionSet);
            plotRegion(i, j - 1, regionKey, regionMap, regionSet);
        }
    }

    private Long determineSides(Map<Character, Set<String>> sideMap) {
        Map<Character, Set<String>> uniqueSidesMap = sideMap
                .entrySet()
                .stream()
                .collect(Collectors.toMap(
                        Map.Entry::getKey,
                        entry -> new HashSet<>(entry.getValue())));
        Map<Character, Set<String>> removedSidesMap = new HashMap<>();

        for (Map.Entry<Character, Set<String>> sideEntry : sideMap.entrySet()) {
            Character direction = sideEntry.getKey();
            if (!removedSidesMap.containsKey(direction))
                removedSidesMap.put(direction, new HashSet<>());

            for (String side : sideEntry.getValue()) {
                if (removedSidesMap.get(direction).contains(side))
                    continue;

                String[] coordinates = side.split(",");
                int i = Integer.parseInt(coordinates[0]);
                int j = Integer.parseInt(coordinates[1]);
                Set<String> neighbors = new HashSet<>();
                identifyNeighbors(i, j, direction, neighbors, sideMap);
                uniqueSidesMap.get(direction).removeAll(neighbors);
                removedSidesMap.get(direction).addAll(neighbors);
                uniqueSidesMap.get(direction).add(side);
            }
        }

        return uniqueSidesMap.values().stream().mapToLong(Set::size).sum();
    }

    private void identifyNeighbors(int i, int j, Character direction, Set<String> neighbors, Map<Character, Set<String>> sideMap) {
        if (i > -1
                && i < rowCount
                && j > - 1
                && j < colCount
                && sideMap.get(direction).contains(i + "," + j)
                && !neighbors.contains(i + "," + j)) {
            neighbors.add(i + "," + j);
            identifyNeighbors(i - 1, j, direction, neighbors, sideMap);
            identifyNeighbors(i, j + 1, direction, neighbors, sideMap);
            identifyNeighbors(i + 1, j, direction, neighbors, sideMap);
            identifyNeighbors(i, j - 1, direction, neighbors, sideMap);
        }
    }

    private boolean evaluateNeighbors(
            String sideCandidate,
            int i,
            int j) {
        String[] coordinates = sideCandidate.split(",");
        int x = Integer.parseInt(coordinates[0]);
        int y = Integer.parseInt(coordinates[1]);

        if (i == x && j == y)
            return false;

        if ((i + 1 == x && j == y)
                || (i - 1 == x && j == y)
                || (i == x && j + 1 == y)
                || (i == x && j - 1 == y))
            return true;

        return true;
    }
}