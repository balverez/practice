package day5;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class PrintQueueTest {
    private static final String EXAMPLE_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-5\\src\\main\\resources\\example";
    private static final String INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-5\\src\\main\\resources\\input";
    private static final int EXAMPLE_RESULT = 143;
    private static final int INPUT_RESULT = 5275;
    private static final int INCORRECTLY_ORDERED_EXAMPLE_RESULT = 123;
    private static final int INCORRECTLY_ORDERED_INPUT_RESULT = 6191;

    @Test
    void evaluateUpdatesWithExample() throws FileNotFoundException {
        PrintQueue printQueue = new PrintQueue(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, printQueue.evaluateUpdates());
    }

    @Test
    void evaluateUpdatesWithInput() throws FileNotFoundException {
        PrintQueue printQueue = new PrintQueue(INPUT_PATH);

        assertEquals(INPUT_RESULT, printQueue.evaluateUpdates());
    }

    @Test
    void evaluateIncorrectlyOrderedUpdatesWithExample() throws FileNotFoundException {
        PrintQueue printQueue = new PrintQueue(EXAMPLE_PATH);

        assertEquals(INCORRECTLY_ORDERED_EXAMPLE_RESULT, printQueue.evaluateIncorrectlyOrderedUpdates());
    }

    @Test
    void evaluateIncorrectlyOrderedUpdatesWithInput() throws FileNotFoundException {
        PrintQueue printQueue = new PrintQueue(INPUT_PATH);

        assertEquals(INCORRECTLY_ORDERED_INPUT_RESULT, printQueue.evaluateIncorrectlyOrderedUpdates());
    }
}