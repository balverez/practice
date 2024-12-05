package day4;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class CeresSearchTest {
    public static final String EXAMPLE_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-4\\src\\main\\resources\\example";
    public static final String INPUT_PATH = "C:\\Users\\brian\\IdeaProjects\\practice\\advent-of-code\\2024\\day-4\\src\\main\\resources\\input";
    public static final int EXAMPLE_RESULT = 18;
    public static final int XMAS_EXAMPLE_RESULT = 9;
    public static final int INPUT_RESULT = 2483;
    public static final int XMAS_INPUT_RESULT = 1925;

    @Test
    void wordSearchWithExample() throws FileNotFoundException {
        CeresSearch ceresSearch = new CeresSearch(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, ceresSearch.wordSearch());
    }

    @Test
    void wordSearchWithInput() throws FileNotFoundException {
        CeresSearch ceresSearch = new CeresSearch(INPUT_PATH);

        assertEquals(INPUT_RESULT, ceresSearch.wordSearch());
    }

    @Test
    void xmasSearchWithExample() throws FileNotFoundException {
        CeresSearch ceresSearch = new CeresSearch(EXAMPLE_PATH);

        assertEquals(XMAS_EXAMPLE_RESULT, ceresSearch.xmasSearch());
    }

    @Test
    void xmasSearchWithInput() throws FileNotFoundException {
        CeresSearch ceresSearch = new CeresSearch(INPUT_PATH);

        assertEquals(XMAS_INPUT_RESULT, ceresSearch.xmasSearch());
    }
}