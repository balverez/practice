package day13;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class ClawContraptionTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-13/src/main/resources/example";
    private static final double EXAMPLE_RESULT = 480;
    private static final double EXAMPLE_RESULT_WITH_CONVERSION = 1.545093E12;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-13/src/main/resources/input";
    private static final double INPUT_RESULT = 30413;
    private static final double INPUT_RESULT_WITH_CONVERSION = 30413;

    @Test
    void optimizeTokensForExample() throws FileNotFoundException {
        ClawContraption clawContraption = new ClawContraption(EXAMPLE_PATH, false);

        assertEquals(EXAMPLE_RESULT, clawContraption.optimizeTokens());
    }

    @Test
    void optimizeTokensForInput() throws FileNotFoundException {
        ClawContraption clawContraption = new ClawContraption(INPUT_PATH, false);

        assertEquals(INPUT_RESULT, clawContraption.optimizeTokens());
    }

    @Test
    void optimizeTokensWithConversionForExample() throws FileNotFoundException {
        ClawContraption clawContraption = new ClawContraption(EXAMPLE_PATH, true);

        assertEquals(EXAMPLE_RESULT_WITH_CONVERSION, clawContraption.optimizeTokens());
    }

    @Test
    void optimizeTokensWithConversionForInput() throws FileNotFoundException {
        ClawContraption clawContraption = new ClawContraption(INPUT_PATH, true);

        assertEquals(INPUT_RESULT_WITH_CONVERSION, clawContraption.optimizeTokens());
    }
}