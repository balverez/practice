package day10;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class HoofItTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-10/src/main/resources/example";
    private static final int EXAMPLE_RESULT = 36;
    private static final int EXAMPLE_RESULT_WITH_PATHS = 81;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-10/src/main/resources/input";
    private static final int INPUT_RESULT = 552;
    private static final int INPUT_RESULT_WITH_PATHS = 1225;

    @Test
    void trailheadScoreSumForExample() throws FileNotFoundException {
        HoofIt hoofIt = new HoofIt(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, hoofIt.trailheadScoreSum());
    }

    @Test
    void trailheadScoreSumForInput() throws FileNotFoundException {
        HoofIt hoofIt = new HoofIt(INPUT_PATH);

        assertEquals(INPUT_RESULT, hoofIt.trailheadScoreSum());
    }

    @Test
    void uniquePathsSumForExample() throws FileNotFoundException {
        HoofIt hoofIt = new HoofIt(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT_WITH_PATHS, hoofIt.trailheadRatingSum());
    }

    @Test
    void uniquePathsSumForInput() throws FileNotFoundException {
        HoofIt hoofIt = new HoofIt(INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_PATHS, hoofIt.trailheadRatingSum());
    }
}