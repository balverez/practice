package day2;

import lombok.Getter;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

@Getter
public class RedNosedReports {
    List<List<Integer>> reports = new ArrayList<>();
    int levelCount = 0;

    public RedNosedReports(String inputPath) throws FileNotFoundException {
        try (Scanner inputScanner = new Scanner(new File(inputPath))) {
            while (inputScanner.hasNextLine()) {
                List<Integer> levels = new ArrayList<>();
                String[] levelStrings = inputScanner.nextLine().split(" ");
                Arrays.stream(levelStrings).forEach(levelString -> levels.add(Integer.parseInt(levelString)));
                reports.add(levels);
            }
        }
    }

    public int analyzeReports(boolean problemDampener) {
        int safeCount = 0;
        for (List<Integer> report : reports) {
            if (isSafe(report))
                safeCount++;
            else if (problemDampener){
                for (int i = 0; i < report.size(); i++) {
                    List<Integer> subReport = new ArrayList<>(report);
                    subReport.remove(i);

                    if (isSafe(subReport)) {
                        safeCount++;
                        break;
                    }
                }
            }
        }

        return safeCount;
    }

    private static boolean isSafe(List<Integer> report) {
        // if difference is greater than 0, we expect an increasing level report
        // if difference is lesser than 0, we expect a decreasing level report
        int difference = report.get(1) - report.get(0);
        for (int j = 1; j < report.size(); j++) {
            int level = report.get(j);
            int previousLevel = report.get(j - 1);

            // check for equality as a fail condition
            if (level == previousLevel
                    || Math.abs(level - previousLevel) > 3
                    || (difference > 0 && (level - previousLevel < 0))
                    || (difference < 0 && (level - previousLevel > 0))) {

                return false;
            }
        }

        return true;
    }
}