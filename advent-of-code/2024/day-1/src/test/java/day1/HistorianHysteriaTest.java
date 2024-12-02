package day1;

import org.junit.jupiter.api.Test;

import java.io.IOException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class HistorianHysteriaTest {
    private static final String INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\main\\resources\\input";
    private static final String TEST_INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\main\\resources\\test-input";
    private static final int TEST_INPUT_TOTAL_DISTANCE = 11;
    private static final int TEST_INPUT_SIMILARITY_SCORE = 31;
    private static final int INPUT_TOTAL_DISTANCE = 1590491;
    private static final int INPUT_TOTAL_SIMILARITY_SCORE = 22588371;


    @Test
    void totalDistanceWithTestInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(TEST_INPUT_PATH);

        assertEquals(TEST_INPUT_TOTAL_DISTANCE, historianHysteria.totalDistance());
    }

    @Test
    void totalDistanceWithInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(INPUT_PATH);

        assertEquals(INPUT_TOTAL_DISTANCE, historianHysteria.totalDistance());
    }

    @Test
    void similarityScoreWithTestInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(TEST_INPUT_PATH);

        assertEquals(TEST_INPUT_SIMILARITY_SCORE, historianHysteria.similarityScore());
    }

    @Test
    void similarityScoreWithInput() throws IOException {
        HistorianHysteria historianHysteria = new HistorianHysteria(INPUT_PATH);

        assertEquals(INPUT_TOTAL_SIMILARITY_SCORE, historianHysteria.similarityScore());
    }
}