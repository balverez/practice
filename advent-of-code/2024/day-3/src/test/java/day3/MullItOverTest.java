package day3;

import org.junit.jupiter.api.Test;

import java.io.IOException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class MullItOverTest {
    public static String EXAMPLE_INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-3\\src\\main\\resources\\exampleInput";
    public static String EXAMPLE_INPUT_PATH_FOR_CONDITIONALS = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-3\\src\\main\\resources\\exampleInputForConditionals";
    public static int EXAMPLE_INPUT_RESULT = 161;
    public static int EXAMPLE_INPUT_RESULT_WITH_CONDITIONALS = 48;
    public static String INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-3\\src\\main\\resources\\input";
    public static int INPUT_RESULT = 188741603;
    public static int INPUT_RESULT_WITH_CONDITIONALS = 67269798;
    public static String TRENTS_INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-3\\src\\main\\resources\\trents-shitty-input";

    @Test
    void mullWithExampleInput() throws IOException {
        MullItOver mullItOver = new MullItOver(EXAMPLE_INPUT_PATH);

        assertEquals(EXAMPLE_INPUT_RESULT, mullItOver.mull());
    }

    @Test
    void mullWithInput() throws IOException {
        MullItOver mullItOver = new MullItOver(INPUT_PATH);

        assertEquals(INPUT_RESULT, mullItOver.mull());
    }

    @Test
    void mullWithConditionalsWithExampleInput() throws IOException {
        MullItOver mullItOver = new MullItOver(EXAMPLE_INPUT_PATH_FOR_CONDITIONALS);

        assertEquals(EXAMPLE_INPUT_RESULT_WITH_CONDITIONALS, mullItOver.mullWithConditionals());
    }

    @Test
    void mullWithConditionalsWithInput() throws IOException {
        MullItOver mullItOver = new MullItOver(INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_CONDITIONALS, mullItOver.mullWithConditionals());
    }

    @Test
    void mullWithConditionalsWithTrentsInput() throws IOException {
        MullItOver mullItOver = new MullItOver(TRENTS_INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_CONDITIONALS, mullItOver.mullWithConditionals());
    }
}