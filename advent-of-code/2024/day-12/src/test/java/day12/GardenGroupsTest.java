package day12;

import org.junit.jupiter.api.Test;

import java.io.FileNotFoundException;

import static org.junit.jupiter.api.Assertions.assertEquals;

class GardenGroupsTest {
    private static final String EXAMPLE_1_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-12/src/main/resources/example1";
    private static final String EXAMPLE_2_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-12/src/main/resources/example2";
    private static final String EXAMPLE_3_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-12/src/main/resources/example3";
    private static final Long EXAMPLE_1_RESULT = 140L;
    private static final Long EXAMPLE_1_RESULT_WITH_BULK_DISCOUNT = 80L;
    private static final Long EXAMPLE_2_RESULT = 772L;
    private static final Long EXAMPLE_2_RESULT_WITH_BULK_DISCOUNT = 436L;
    private static final Long EXAMPLE_3_RESULT = 1930L;
    private static final Long EXAMPLE_3_RESULT_WITH_BULK_DISCOUNT = 1206L;
    private static final String INPUT_PATH = "/Users/balverez/Workplace/practice/advent-of-code/2024/day-12/src/main/resources/input";
    private static final Long INPUT_RESULT = 1396562L;
    private static final Long INPUT_RESULT_WITH_BULK_DISCOUNT = 844132L;

    @Test
    void fencingCostForExample1() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_1_PATH);

        assertEquals(EXAMPLE_1_RESULT, gardenGroups.fencingCost());
    }

    @Test
    void fencingCostForExample2() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_2_PATH);

        assertEquals(EXAMPLE_2_RESULT, gardenGroups.fencingCost());
    }

    @Test
    void fencingCostForExample3() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_3_PATH);

        assertEquals(EXAMPLE_3_RESULT, gardenGroups.fencingCost());
    }

    @Test
    void fencingCostForInput() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(INPUT_PATH);

        assertEquals(INPUT_RESULT, gardenGroups.fencingCost());
    }

    @Test
    void fencingCostWithBulkDiscountForExample1() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_1_PATH);

        assertEquals(EXAMPLE_1_RESULT_WITH_BULK_DISCOUNT, gardenGroups.fencingCostWithBulkDiscount());
    }

    @Test
    void fencingCostWithBulkDiscountForExample2() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_2_PATH);

        assertEquals(EXAMPLE_2_RESULT_WITH_BULK_DISCOUNT, gardenGroups.fencingCostWithBulkDiscount());
    }

    @Test
    void fencingCostWithBulkDiscountForExample3() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(EXAMPLE_3_PATH);

        assertEquals(EXAMPLE_3_RESULT_WITH_BULK_DISCOUNT, gardenGroups.fencingCostWithBulkDiscount());
    }

    @Test
    void fencingCostWithBulkDiscountForInput() throws FileNotFoundException {
        GardenGroups gardenGroups = new GardenGroups(INPUT_PATH);

        assertEquals(INPUT_RESULT_WITH_BULK_DISCOUNT, gardenGroups.fencingCostWithBulkDiscount());
    }
}