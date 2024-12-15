package day11;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class PlutonianPebblesTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-11/src/main/resources/example";
    private static final long EXAMPLE_RESULT_25 = 55312;
    private static final long EXAMPLE_RESULT_75 = 65601038650482L;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-11/src/main/resources/input";
    private static final long INPUT_RESULT_25 = 185205;
    private static final long INPUT_RESULT_75 = 221280540398419L;

    @Test
    void countStonesForExample() throws FileNotFoundException {
        PlutonianPebbles plutonianPebbles = new PlutonianPebbles(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT_25, plutonianPebbles.countStones(25));
    }

    @Test
    void countStonesForInput() throws FileNotFoundException {
        PlutonianPebbles plutonianPebbles = new PlutonianPebbles(INPUT_PATH);

        assertEquals(INPUT_RESULT_25, plutonianPebbles.countStones(25));
    }

    @Test
    void countStonesWith75BlinksForExample() throws FileNotFoundException {
        PlutonianPebbles plutonianPebbles = new PlutonianPebbles(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT_75, plutonianPebbles.countStones(75));
    }

    @Test
    void countStonesWith75BlinksForInput() throws FileNotFoundException {
        PlutonianPebbles plutonianPebbles = new PlutonianPebbles(INPUT_PATH);

        assertEquals(INPUT_RESULT_75, plutonianPebbles.countStones(75));
    }
}