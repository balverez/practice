package day6;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class GuardGallivantTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-6/src/main/resources/example";
    private static final int EXAMPLE_RESULT = 41;
    private static final int EXAMPLE_GUARD_LOOP_RESULT = 6;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-6/src/main/resources/input";
    private static final int INPUT_RESULT = 5212;
    private static final int INPUT_GUARD_LOOP_RESULT = 1767;

    @Test
    void predictGuardRouteWithExample() throws FileNotFoundException {
        GuardGallivant guardGallivant = new GuardGallivant(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, guardGallivant.predictGuardRoute());
    }

    @Test
    void predictGuardRouteWithInput() throws FileNotFoundException {
        GuardGallivant guardGallivant = new GuardGallivant(INPUT_PATH);

        assertEquals(INPUT_RESULT, guardGallivant.predictGuardRoute());
    }

    @Test
    void determineGuardLoopsWithExample() throws FileNotFoundException {
        GuardGallivant guardGallivant = new GuardGallivant(EXAMPLE_PATH);

        assertEquals(EXAMPLE_GUARD_LOOP_RESULT, guardGallivant.determineGuardLoops());
    }

    @Test
    void determineGuardLoopsWithInput() throws FileNotFoundException {
        GuardGallivant guardGallivant = new GuardGallivant(INPUT_PATH);

        assertEquals(INPUT_GUARD_LOOP_RESULT, guardGallivant.determineGuardLoops());
    }
}