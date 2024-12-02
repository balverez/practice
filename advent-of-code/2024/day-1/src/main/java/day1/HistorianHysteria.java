package day1;

import lombok.Getter;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

@Getter
public class HistorianHysteria {
    private final List<Integer> list1 = new ArrayList<>();

    private final List<Integer> list2 = new ArrayList<>();

    public HistorianHysteria(String inputPath) throws IOException {
        try (Scanner inputScanner = new Scanner(new File(inputPath))) {
            while (inputScanner.hasNextLine()) {
                if (inputScanner.hasNextInt())
                    list1.add(inputScanner.nextInt());

                if (inputScanner.hasNextInt())
                    list2.add(inputScanner.nextInt());
            }
        }
    }

    public int totalDistanceOfTwoLists() {
        int totalDistance = 0;
        list1.sort(Integer::compareTo);
        list2.sort(Integer::compareTo);

        for (int i = 0; i < list1.size() && i < list2.size(); i++) {
            totalDistance += Math.abs(list1.get(i) - list2.get(i));
        }

        return totalDistance;
    }
}