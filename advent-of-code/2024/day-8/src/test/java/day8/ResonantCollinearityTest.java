package day8;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class ResonantCollinearityTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-8/src/main/resources/example";
    private static final int EXAMPLE_RESULT = 14;
    private static final int EXAMPLE_RESULT_WITH_HARMONICS = 34;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-8/src/main/resources/input";
    private static final int INPUT_RESULT = 299;
    private static final int INPUT_RESULT_WITH_HARMONICS = 1032;

    @Test
    void determineAntinodesForExample() throws FileNotFoundException {
        ResonantCollinearity resonantCollinearity = new ResonantCollinearity(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, resonantCollinearity.determineAntinodes());
    }

    @Test
    void determineAntinodesForInput() throws FileNotFoundException {
        ResonantCollinearity resonantCollinearity = new ResonantCollinearity(INPUT_PATH);

        assertEquals(INPUT_RESULT, resonantCollinearity.determineAntinodes());
    }

    @Test
    void determineAntinodesWithHarmonicsForExample() throws FileNotFoundException {
        ResonantCollinearity resonantCollinearity = new ResonantCollinearity(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT_WITH_HARMONICS, resonantCollinearity.determineAntinodesWithHarmonics());
    }

    @Test
    void determineAntinodesWithHarmonicsForInput() throws FileNotFoundException {
        ResonantCollinearity resonantCollinearity = new ResonantCollinearity(INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_HARMONICS, resonantCollinearity.determineAntinodesWithHarmonics());
    }
}