package day10;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.util.stream.IntStream;
import java.util.stream.Stream;

public class HoofIt {
    private int colCount;
    private int rowCount;
    private int[][] matrix;

    public HoofIt(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            List<String> lines = new ArrayList<>();
            while (scanner.hasNextLine())
                lines.add(scanner.nextLine());

            colCount = lines.getFirst().length();
            rowCount = lines.size();
            matrix = new int[rowCount][colCount];
            IntStream.range(0, rowCount)
                    .forEach(i -> matrix[i] = Arrays.copyOf(
                            Stream.of(lines.get(i).split("")).mapToInt(Integer::parseInt).toArray(),
                            colCount));
        }
    }

    public int trailheadScoreSum() {
        int trailheadScoreSum = 0;
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
                if (matrix[i][j] == 0){
                    Set<String> peakMap = new HashSet<>();
                    Set<String> pathMap = new HashSet<>();
                    pathfind(i, j, 0, "", peakMap, pathMap);
                    trailheadScoreSum += peakMap.size();
                }

        return trailheadScoreSum;
    }

    public int trailheadRatingSum() {
        int trailheadRatingSum = 0;
        for (int i = 0; i < rowCount; i++)
            for (int j = 0; j < colCount; j++)
                if (matrix[i][j] == 0){
                    Set<String> peakMap = new HashSet<>();
                    Set<String> pathMap = new HashSet<>();
                    pathfind(i, j, 0, "", peakMap, pathMap);
                    trailheadRatingSum += pathMap.size();
                }

        return trailheadRatingSum;
    }


    private void pathfind(
            int i,
            int j,
            int searchHeight,
            String path,
            Set<String> peakMap,
            Set<String> pathMap) {
        if (i > -1
                && i < rowCount
                && j > -1
                && j < colCount
                && matrix[i][j] == searchHeight) {

            if (searchHeight == 9) {
                peakMap.add(i + "," + j);
                pathMap.add(path + "," + i + "," + j);
                return;
            }

            searchHeight++;
            pathfind(i - 1, j, searchHeight, path + "," + i + "," + j, peakMap, pathMap);
            pathfind(i, j + 1, searchHeight, path + "," + i + "," + j, peakMap, pathMap);
            pathfind(i + 1, j, searchHeight, path + "," + i + "," + j, peakMap, pathMap);
            pathfind(i, j - 1, searchHeight, path + "," + i + "," + j, peakMap, pathMap);
        }
    }
}