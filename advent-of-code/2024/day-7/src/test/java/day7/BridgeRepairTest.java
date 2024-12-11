package day7;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class BridgeRepairTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-7/src/main/resources/example";
    private static final long EXAMPLE_RESULT = 3749;
    private static final long EXAMPLE_CONCATENATION_RESULT = 11387;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-7/src/main/resources/input";
    private static final long INPUT_RESULT = 7579994664753L;
    private static final long INPUT_CONCATENATION_RESULT = 438027111276610L;

    @Test
    void calibrateWithExample() throws FileNotFoundException {
        BridgeRepair bridgeRepair = new BridgeRepair(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, bridgeRepair.calibrate());
    }

    @Test
    void calibrateWithInput() throws FileNotFoundException {
        BridgeRepair bridgeRepair = new BridgeRepair(INPUT_PATH);

        assertEquals(INPUT_RESULT, bridgeRepair.calibrate());
    }

    @Test
    void calibrateWithConcatenationWithExample() throws FileNotFoundException {
        BridgeRepair bridgeRepair = new BridgeRepair(EXAMPLE_PATH);

        assertEquals(EXAMPLE_CONCATENATION_RESULT, bridgeRepair.calibrateWithConcatenation());
    }

    @Test
    void calibrateWithConcatenationWithInput() throws FileNotFoundException {
        BridgeRepair bridgeRepair = new BridgeRepair(INPUT_PATH);

        assertEquals(INPUT_CONCATENATION_RESULT, bridgeRepair.calibrateWithConcatenation());
    }
}