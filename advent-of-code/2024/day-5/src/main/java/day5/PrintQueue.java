package day5;

import lombok.Getter;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;
import java.util.HashMap;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;

@Getter
public class PrintQueue {
    Map<Integer, Set<Integer>> orderingRules = new HashMap<>();
    List<List<Integer>> updates = new ArrayList<>();

    public PrintQueue(String inputPath) throws FileNotFoundException {
        try (Scanner inputScanner = new Scanner(new File(inputPath))) {
            while (inputScanner.hasNextLine()) {
                String line = inputScanner.nextLine();

                if (line.contains("|")) {
                    String[] data = line.split("\\|");
                    List<Integer> pages = Arrays.stream(data).map(Integer::parseInt).toList();

                    if (orderingRules.containsKey(pages.getFirst()))
                        orderingRules.get(pages.getFirst()).add(pages.get(1));
                    else {
                        orderingRules.put(pages.getFirst(), new HashSet<>());
                        orderingRules.get(pages.getFirst()).add(pages.get(1));
                    }
                }

                if (line.contains(",")) {
                    String[] data = line.split(",");
                    updates.add(Arrays.stream(data).map(Integer::parseInt).toList());
                }
            }
        }
    }

    public int evaluateUpdates() {
        int validSum = 0;

        for (List<Integer> update : updates) {
            Set<Integer> printedPages = new HashSet<>();
            for (int i = 0; i < update.size(); i++) {
                Integer page = update.get(i);
                if (orderingRules.getOrDefault(page, new HashSet<>()).stream()
                        .noneMatch(printedPages::contains)) {

                    printedPages.add(page);

                    if (i + 1 == update.size()) {
                        validSum += update.get(update.size() / 2);
                    }
                } else {

                    break;
                }
            }
        }

        return validSum;
    }

    public int evaluateIncorrectlyOrderedUpdates() {
        int validSum = 0;

        List<LinkedList<Integer>> updates = determineIncorrectlyOrderedUpdates();
        for (LinkedList<Integer> update : updates) {
            Set<Integer> printedPages = new HashSet<>();
            Map<Integer, Integer> pageIndicesMap = new HashMap<>();

            for (int i = 0; i < update.size(); i++) {
                int page = update.get(i);
                if (orderingRules.getOrDefault(page, new HashSet<>()).stream()
                        .noneMatch(printedPages::contains)) {

                    printedPages.add(page);
                    pageIndicesMap.put(page, i);
                } else {
                    Integer replacementPage = orderingRules.get(page).stream()
                            .filter(printedPages::contains)
                            .min(Comparator.comparing(pageIndicesMap::get))
                            .get();

                    Integer replacementIndex = pageIndicesMap.get(replacementPage);
                    pageIndicesMap.put(page, replacementIndex);
                    pageIndicesMap.put(replacementPage, replacementIndex + 1);
                    update.add(replacementIndex, page);
                    printedPages.add(page);
                    update.remove(i + 1);

                    for (int j = replacementIndex; j < i + 1; j++) {
                        pageIndicesMap.put(update.get(j), j);
                    }
                }
            }

            validSum += update.get(update.size() / 2);
        }


        return validSum;
    }

    private List<LinkedList<Integer>> determineIncorrectlyOrderedUpdates() {
        List<List<Integer>> invalidUpdates = new ArrayList<>();

        for (List<Integer> update : updates) {
            Set<Integer> printedPages = new HashSet<>();
            for (int i = 0; i < update.size(); i++) {
                Integer page = update.get(i);
                if (orderingRules.getOrDefault(page, new HashSet<>()).stream()
                        .noneMatch(printedPages::contains)) {

                    printedPages.add(page);
                } else {
                    invalidUpdates.add(update);
                    break;
                }
            }
        }

        List<LinkedList<Integer>> updates = new ArrayList<>();
        invalidUpdates.forEach(invalidUpdate -> {
            LinkedList<Integer> update = new LinkedList<>();
            invalidUpdate.forEach(update::addLast);
            updates.add(update);
        });

        return updates;
    }
}