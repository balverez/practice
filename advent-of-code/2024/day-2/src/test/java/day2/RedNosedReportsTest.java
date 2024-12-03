package day2;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class RedNosedReportsTest {
    private static final String EXAMPLE_INPUT_FILE_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\test\\resources\\example-input";
    private static final String INPUT_FILE_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-2\\src\\test\\resources\\input";
    private static final int EXAMPLE_INPUT_SAFE_REPORT_COUNT = 2;
    private static final int EXAMPLE_INPUT_SAFE_REPORT_COUNT_WITH_PROBLEM_DAMPENER = 4;
    private static final int INPUT_SAFE_REPORT_COUNT = 680;
    private static final int INPUT_SAFE_REPORT_COUNT_WITH_PROBLEM_DAMPENER = 710;

    @Test
    void analyzeReportsWithExampleInput() throws FileNotFoundException {
        RedNosedReports redNosedReports = new RedNosedReports(EXAMPLE_INPUT_FILE_PATH);

        assertEquals(EXAMPLE_INPUT_SAFE_REPORT_COUNT, redNosedReports.analyzeReports(false));
    }

    @Test
    void analyzeReportsWithInput() throws FileNotFoundException {
        RedNosedReports redNosedReports = new RedNosedReports(INPUT_FILE_PATH);

        assertEquals(INPUT_SAFE_REPORT_COUNT, redNosedReports.analyzeReports(false));
    }

    @Test
    void analyzeReportsWithProblemDampenerWithExampleInput() throws FileNotFoundException {
        RedNosedReports redNosedReports = new RedNosedReports(EXAMPLE_INPUT_FILE_PATH);

        assertEquals(EXAMPLE_INPUT_SAFE_REPORT_COUNT_WITH_PROBLEM_DAMPENER, redNosedReports.analyzeReports(true));
    }

    @Test
    void analyzeReportsWithProblemDampenerWithInput() throws FileNotFoundException {
        RedNosedReports redNosedReports = new RedNosedReports(INPUT_FILE_PATH);

        assertEquals(INPUT_SAFE_REPORT_COUNT_WITH_PROBLEM_DAMPENER, redNosedReports.analyzeReports(true));
    }
}