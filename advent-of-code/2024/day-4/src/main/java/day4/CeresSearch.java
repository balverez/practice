package day4;

import lombok.Getter;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

@Getter
public class CeresSearch {
    private static final char[] SEARCH_WORD_ARRAY = { 'X', 'M', 'A', 'S'};
    private static final int[] ROW_NAV_ARRAY = { -1, -1, 0, 1, 1, 1, 0, -1 };
    private static final int[] COLUMN_NAV_ARRAY = { 0, 1, 1, 1, 0, -1, -1, -1 };
    private static final int[] XMAS_ROW_NAV_ARRAY = { -1, -1, 1, 1 };
    private static final int[] XMAS_COLUMN_NAV_ARRAY = { -1, 1, 1, -1 };

    private final int columnCount;

    private final int rowCount;

    private final char[][] matrix;

    public CeresSearch(String inputPath) throws FileNotFoundException {
        try (Scanner inputScanner = new Scanner(new File(inputPath))) {
            List<String> inputLines = new ArrayList<>();
            while (inputScanner.hasNextLine()) {
                inputLines.add(inputScanner.nextLine());
            }

            matrix = new char[inputLines.size()][inputLines.getFirst().length()];
            for (int i = 0; i < inputLines.size(); i++) {
                char[] lineCharacters = inputLines.get(i).toCharArray();
                System.arraycopy(lineCharacters, 0, matrix[i], 0, lineCharacters.length);
            }

            rowCount = matrix.length;
            columnCount = matrix[0].length;
        }
    }

    public int wordSearch() {
        int instanceCount = 0;

        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < columnCount; j++) {
                if (matrix[i][j] == SEARCH_WORD_ARRAY[0]) {
                    for (int k = 0; k < ROW_NAV_ARRAY.length; k++) {
                        instanceCount += evaluatePath(1, i, j, k);
                    }
                }
            }
        }

        return instanceCount;
    }

    public int xmasSearch() {
        int instanceCount = 0;

        for (int i = 0; i < rowCount; i++) {
            for (int j = 0; j < columnCount; j++) {
                if (matrix[i][j] == SEARCH_WORD_ARRAY[2]) {
                    if (evaluateXmasPath(i, j)) {
                        instanceCount++;
                    }
                }
            }
        }

        return instanceCount;
    }

    private int evaluatePath(int searchPointer, int pastRow, int pastColumn, int nav) {
        int i = pastRow + ROW_NAV_ARRAY[nav];
        int j = pastColumn + COLUMN_NAV_ARRAY[nav];
        if (i < rowCount
                && i > -1
                && j < columnCount
                && j > -1
                && searchPointer < SEARCH_WORD_ARRAY.length
                && matrix[i][j] == SEARCH_WORD_ARRAY[searchPointer]) {

            if (searchPointer == SEARCH_WORD_ARRAY.length - 1) {
                return 1;
            }

            return evaluatePath(++searchPointer, i, j, nav);
        }

        return 0;
    }

    private boolean evaluateXmasPath(int i, int j) {
        int navLength = XMAS_ROW_NAV_ARRAY.length;

        for (int k = 0; k < navLength; k++) {
            int x1 = i + XMAS_ROW_NAV_ARRAY[k % navLength];
            int x2 = i + XMAS_ROW_NAV_ARRAY[(k + 1) % navLength];
            int x3 = i + XMAS_ROW_NAV_ARRAY[(k + 2) % navLength];
            int x4 = i + XMAS_ROW_NAV_ARRAY[(k + 3) % navLength];

            int y1 = j + XMAS_COLUMN_NAV_ARRAY[k % navLength];
            int y2 = j + XMAS_COLUMN_NAV_ARRAY[(k + 1) % navLength];
            int y3 = j + XMAS_COLUMN_NAV_ARRAY[(k + 2) % navLength];
            int y4 = j + XMAS_COLUMN_NAV_ARRAY[(k + 3) % navLength];

            if (evaluateTraversal(x1, y1, 1)
                    && evaluateTraversal(x2, y2, 1)
                    && evaluateTraversal(x3, y3, 3)
                    && evaluateTraversal(x4, y4, 3)) {

                return true;
            }
        }

        return false;
    }

    private boolean evaluateTraversal(int x, int y, int searchPointer) {
        return x < rowCount
                && x > -1
                && y < columnCount
                && y > -1
                && matrix[x][y] == SEARCH_WORD_ARRAY[searchPointer];
    }
}