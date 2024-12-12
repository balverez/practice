package day8;

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
import java.util.stream.IntStream;

public class ResonantCollinearity {
    private final int colCount;
    private final int rowCount;
    private final char[][] matrix;

    public ResonantCollinearity(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            List<String> lines = new ArrayList<>();
            while (scanner.hasNextLine())
                lines.add(scanner.nextLine());

            colCount = lines.getFirst().length();
            rowCount = lines.size();
            matrix = new char[rowCount][colCount];
            IntStream.range(0, rowCount)
                    .forEach(i -> matrix[i] = Arrays.copyOf(lines.get(i).toCharArray(), colCount));
        }
    }

    public int determineAntinodes() {
        Map<Character, Set<String>> frequencyMap = new HashMap<>();
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (matrix[i][j] != '.') {
                    if (!frequencyMap.containsKey(matrix[i][j]))
                        frequencyMap.put(matrix[i][j], new HashSet<>());

                    frequencyMap.get(matrix[i][j]).add(i + "," + j);
                }
            }
        }

        return calculateAntinodes(frequencyMap);
    }

    public int determineAntinodesWithHarmonics() {
        Map<Character, Set<String>> frequencyMap = new HashMap<>();
        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < colCount; j++) {
                if (matrix[i][j] != '.') {
                    if (!frequencyMap.containsKey(matrix[i][j]))
                        frequencyMap.put(matrix[i][j], new HashSet<>());

                    frequencyMap.get(matrix[i][j]).add(i + "," + j);
                }
            }
        }

        return calculateAntinodesWithHarmonics(frequencyMap);
    }

    private int calculateAntinodes(Map<Character, Set<String>> frequencyMap) {
        Set<String> antinodes = new HashSet<>();
        for (Character key : frequencyMap.keySet()) {
            List<String> frequencySources = new ArrayList<>(frequencyMap.get(key));

            while (!frequencySources.isEmpty()) {
                int[] frequency = extractFrequency(frequencySources.getFirst());

                frequencySources.removeFirst();
                searchResonances(frequencySources, frequency, antinodes);
            }
        }

        return antinodes.size();
    }

    private void searchResonances(List<String> frequencySources, int[] frequency, Set<String> antinodes) {
        for (int[] source : frequencySources.stream().map(ResonantCollinearity::extractFrequency).toList()) {
            int rowDistance = frequency[0] - source[0];
            int colDistance = frequency[1] - source[1];

            int[] a = { source[0] - rowDistance, source[1] - colDistance };
            int[] b = { frequency[0] + rowDistance, frequency[1] + colDistance };

            int[][] antinodeCandidates = { a, b };
            Arrays.stream(antinodeCandidates)
                    .filter(coordinate ->
                            !Arrays.equals(coordinate, source)
                                    && !Arrays.equals(coordinate, frequency)
                                    && coordinate[0] > -1
                                    && coordinate[0] < rowCount
                                    && coordinate[1] > -1
                                    && coordinate[1] < colCount)
                    .forEach(coordinate ->
                            antinodes.add(coordinate[0] + "," + coordinate[1]));
        }
    }

    private int calculateAntinodesWithHarmonics(Map<Character, Set<String>> frequencyMap) {
        Set<String> antinodes = new HashSet<>();
        for (Character key : frequencyMap.keySet()) {
            List<String> frequencySources = new ArrayList<>(frequencyMap.get(key));

            while (!frequencySources.isEmpty()) {
                int[] frequency = extractFrequency(frequencySources.getFirst());

                frequencySources.removeFirst();
                searchResonancesWithHarmonics(frequencySources, frequency, antinodes);
            }
        }

        return antinodes.size();
    }

    private void searchResonancesWithHarmonics(List<String> frequencySources, int[] frequency, Set<String> antinodes) {
        for (int[] source : frequencySources.stream().map(ResonantCollinearity::extractFrequency).toList()) {
            int rowDistance = frequency[0] - source[0];
            int colDistance = frequency[1] - source[1];

            int i = source[0];
            int j = source[1];
            while (i > -1 && i < rowCount && j > -1 && j < colCount) {
                antinodes.add(i + "," + j);
                i -= rowDistance;
                j -= colDistance;
            }

            i = frequency[0];
            j = frequency[1];
            while (i > -1 && i < rowCount && j > -1 && j < colCount) {
                antinodes.add(i + "," + j);
                i += rowDistance;
                j += colDistance;
            }
        }
    }

    private static int[] extractFrequency(String frequencyString) {
        return Arrays.stream(frequencyString.split(","))
                .mapToInt(Integer::parseInt)
                .toArray();
    }
}