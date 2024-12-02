package day1;

import org.junit.jupiter.api.Test;

import java.io.IOException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class HistorianHysteriaTest {
    private static final String INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\main\\resources\\input";
    private static final String TEST_INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\main\\resources\\test-input";
    private static final int TEST_INPUT_ANSWER = 11;
    private static final int INPUT_ANSWER = 1590491;

    @Test
    void totalDistanceOfTwoListsWithTestInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(TEST_INPUT_PATH);

        assertEquals(TEST_INPUT_ANSWER, historianHysteria.totalDistanceOfTwoLists());
    }

    @Test
    void totalDistanceOfTwoListsWithInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(INPUT_PATH);

        assertEquals(INPUT_ANSWER, historianHysteria.totalDistanceOfTwoLists());
    }
}