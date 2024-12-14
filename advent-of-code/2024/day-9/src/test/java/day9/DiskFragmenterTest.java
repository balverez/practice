package day9;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.*;

class DiskFragmenterTest {
    private static final String EXAMPLE_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-9/src/main/resources/example";
    private static final long EXAMPLE_RESULT = 1928;
    private static final long EXAMPLE_RESULT_WITH_WHOLE_FILES = 2858;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-9/src/main/resources/input";
    private static final long INPUT_RESULT = 6346871685398L;
    private static final long INPUT_RESULT_WITH_WHOLE_FILES = 6373055193464L;

    @Test
    void checksumForExample() throws FileNotFoundException {
        DiskFragmenter diskFragmenter = new DiskFragmenter(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT, diskFragmenter.checksum());
    }

    @Test
    void checksumForInput() throws FileNotFoundException {
        DiskFragmenter diskFragmenter = new DiskFragmenter(INPUT_PATH);

        assertEquals(INPUT_RESULT, diskFragmenter.checksum());
    }

    @Test
    void checksumWithWholeFilesForExample() throws FileNotFoundException {
        DiskFragmenter diskFragmenter = new DiskFragmenter(EXAMPLE_PATH);

        assertEquals(EXAMPLE_RESULT_WITH_WHOLE_FILES, diskFragmenter.checksumWithWholeFileCompression());
    }

    @Test
    void checksumWithWholeFilesForInput() throws FileNotFoundException {
        DiskFragmenter diskFragmenter = new DiskFragmenter(INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_WHOLE_FILES, diskFragmenter.checksumWithWholeFileCompression());
    }
}