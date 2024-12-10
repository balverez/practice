package day6;

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

public class GuardGallivant {
    private static final int[] ROW_NAV_ARRAY = { -1, 0, 1, 0 };
    private static final int[] COL_NAV_ARRAY = { 0, 1, 0, -1 };
    private static final char[] DIR_NAV_ARRAY = { '^', '>', 'v', '<' };

    private final char[][] matrix;

    private final int colCount;

    private final int rowCount;

    private String startingCoordinates;

    private int startingDirection;


    public GuardGallivant(String inputPath) throws FileNotFoundException {
        List<String> lines = new ArrayList<>();
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            while (scanner.hasNextLine()) {
                lines.add(scanner.nextLine());
            }
        }

        colCount = lines.getFirst().length();
        rowCount = lines.size();
        matrix = new char[rowCount][colCount];
        for (int i = 0; i < lines.size(); i++) {
            String line = lines.get(i);
            matrix[i] = Arrays.copyOf(line.toCharArray(), colCount);
        }
    }

    public int predictGuardRoute() {
        Map<Integer, Set<String>> visitedSpaceMap = new HashMap<>();
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
                for (int k = 0; k < DIR_NAV_ARRAY.length; k++)
                    if (matrix[i][j] == DIR_NAV_ARRAY[k]) {
                        startingCoordinates = i + "," + j;
                        startingDirection = k;

                        if (!visitedSpaceMap.containsKey(k))
                            visitedSpaceMap.put(k, new HashSet<>());

                        visitedSpaceMap.get(k).add(i + "," + j);
                        guardPatrol(i, j, k, matrix, visitedSpaceMap);
                    }

        Set<String> visitedSpaces = visitedSpaceMap
                .entrySet()
                .stream()
                .flatMap(entry -> entry.getValue().stream())
                .collect(Collectors.toSet());

        return visitedSpaces.size();
    }

    public int determineGuardLoops() {
        int loopSum = 0;
        predictGuardRoute();
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
                if (!(i + "," + j).equals(startingCoordinates) && evaluateLoop(i, j, new HashMap<>()))
                    loopSum++;

        return loopSum;
    }

    private boolean evaluateLoop(int i, int j, Map<Integer, Set<String>> visitedSpaceMap) {
        char[][] timeMatrix = Arrays.stream(matrix).map(char[]::clone).toArray(char[][]::new);

        timeMatrix[i][j] = '#';
        String[] coordinates = startingCoordinates.split(",");
        return guardPatrol(
                Integer.parseInt(coordinates[0]),
                Integer.parseInt(coordinates[1]),
                startingDirection,
                timeMatrix,
                new HashMap<>());
    }

    private boolean guardPatrol(
            int pastRow,
            int pastColumn,
            int dirPointer,
            char[][] matrix,
            Map<Integer, Set<String>> visitedSpaceMap) {
        int i = pastRow + ROW_NAV_ARRAY[dirPointer];
        int j = pastColumn + COL_NAV_ARRAY[dirPointer];

        while (i > -1
                && i < rowCount
                && j > -1
                && j < colCount) {

            if (visitedSpaceMap.containsKey(dirPointer)
                    && visitedSpaceMap.get(dirPointer).contains(i + "," + j))
                return true;

            if (matrix[i][j] == '#') {
                i -=  ROW_NAV_ARRAY[dirPointer];
                j -= COL_NAV_ARRAY[dirPointer];
                dirPointer = (dirPointer + 1) % DIR_NAV_ARRAY.length;
                i += ROW_NAV_ARRAY[dirPointer];
                j += COL_NAV_ARRAY[dirPointer];
            } else {
                if (!visitedSpaceMap.containsKey(dirPointer))
                    visitedSpaceMap.put(dirPointer, new HashSet<>());

                visitedSpaceMap.get(dirPointer).add(i + "," + j);
                i += ROW_NAV_ARRAY[dirPointer];
                j += COL_NAV_ARRAY[dirPointer];
            }
        }

        return false;
    }
}