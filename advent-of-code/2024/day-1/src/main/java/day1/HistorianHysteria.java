package day1;

import lombok.Getter;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

@Getter
public class HistorianHysteria {
    private final List<Integer> leftList = new ArrayList<>();

    private final List<Integer> rightList = new ArrayList<>();

    public HistorianHysteria(String inputPath) throws IOException {
        try (Scanner inputScanner = new Scanner(new File(inputPath))) {
            while (inputScanner.hasNextLine()) {
                if (inputScanner.hasNextInt())
                    leftList.add(inputScanner.nextInt());

                if (inputScanner.hasNextInt())
                    rightList.add(inputScanner.nextInt());
            }
        }
    }

    public int totalDistance() {
        int totalDistance = 0;
        leftList.sort(Integer::compareTo);
        rightList.sort(Integer::compareTo);

        for (int i = 0; i < leftList.size() && i < rightList.size(); i++) {
            totalDistance += Math.abs(leftList.get(i) - rightList.get(i));
        }

        return totalDistance;
    }

    public int similarityScore() {
        int similarityScore = 0;
        Map<Integer, Integer> digitInstanceMap = new HashMap<>();
        rightList.forEach(
                x -> digitInstanceMap.put(x, digitInstanceMap.getOrDefault(x, 0) + 1));

        for (int number : leftList) {
            similarityScore += number * digitInstanceMap.getOrDefault(number, 0);
        }

        return similarityScore;
    }
}