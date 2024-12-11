package day7;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.util.List;

public class BridgeRepair {
    private final List<Equation> equations = new ArrayList<>();

    public BridgeRepair(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            while (scanner.hasNextLine()) {
                String line = scanner.nextLine();
                String[] components = line.split(":");
                long result = Long.parseLong(components[0].trim());
                List<Long> numbers = new ArrayList<>();
                Arrays.stream(components[1].trim().split(" "))
                        .mapToLong(Long::parseLong)
                        .forEach(numbers::add);

                equations.add(new Equation(result, numbers));
            }
        }
    }

    public long calibrate() {
        long totalCalibrationResult = 0;
        for (Equation equation : equations) {
            Set<Long> results = new HashSet<>();
            recurse(equation.getNumbers(), 1, equation.getNumbers().getFirst(), results);
            if (results.contains(equation.getResult()))
                totalCalibrationResult += equation.getResult();
        }

        return totalCalibrationResult;
    }

    public long calibrateWithConcatenation() {
        long totalCalibrationResult = 0;
        for (Equation equation : equations) {
            Set<Long> results = new HashSet<>();
            recurseWithConcatenation(
                    equation.getNumbers(),
                    1,
                    equation.getNumbers().getFirst(),
                    results);

            if (results.contains(equation.getResult()))
                totalCalibrationResult += equation.getResult();
        }

        return totalCalibrationResult;
    }

    private void recurse(List<Long> numbers, int i, long value, Set<Long> results) {
        if (i < numbers.size()) {
            recurse(numbers, i + 1, value + numbers.get(i), results);
            recurse(numbers, i + 1, value * numbers.get(i), results);
        } else
            results.add(value);
    }

    private void recurseWithConcatenation(List<Long> numbers, int i, long value, Set<Long> results) {
        if (i < numbers.size()) {
            recurseWithConcatenation(numbers, i + 1, value + numbers.get(i), results);
            recurseWithConcatenation(numbers, i + 1, value * numbers.get(i), results);
            recurseWithConcatenation(numbers, i + 1, Long.parseLong(String.valueOf(value) + String.valueOf(numbers.get(i))), results);
        } else
            results.add(value);
    }
}