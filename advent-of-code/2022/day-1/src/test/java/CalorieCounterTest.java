import org.junit.jupiter.api.Test;

import java.io.File;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class CalorieCounterTest {
    @Test
    public void count_withValidTestFile_Succeeds() {
        // Arrange & Act
        File file = new File("C:\\Users\\brian\\source\\repos\\practice\\advent-of-code\\2022\\day-1\\src\\test\\resources\\test.txt");
        Integer result = new CalorieCounter().count(file, 1);

        // Assert
        assertEquals(result, 24000);
    }

    @Test
    public void count_withValidInputFile_Succeeds() {
        // Arrange & Act
        File file = new File("C:\\Users\\brian\\source\\repos\\practice\\advent-of-code\\2022\\day-1\\src\\test\\resources\\input.txt");
        Integer result = new CalorieCounter().count(file, 1);

        // Assert
        assertEquals(result, 69206);
    }

    @Test
    public void countTopThree_withValidTestFile_Succeeds() {
        // Arrange & Act
        File file = new File("C:\\Users\\brian\\source\\repos\\practice\\advent-of-code\\2022\\day-1\\src\\test\\resources\\test.txt");
        Integer result = new CalorieCounter().count(file, 3);

        // Assert
        assertEquals(result, 45000);
    }

    @Test
    public void countTopThree_withValidInputFile_Succeeds() {
        // Arrange & Act
        File file = new File("C:\\Users\\brian\\source\\repos\\practice\\advent-of-code\\2022\\day-1\\src\\test\\resources\\input.txt");
        Integer result = new CalorieCounter().count(file, 3);

        // Assert
        assertEquals(result, 197400);
    }
}
