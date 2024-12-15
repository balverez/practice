package day11;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Scanner;

public class PlutonianPebbles {
    private final List<Long> stones = new ArrayList<>();

    public PlutonianPebbles(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            if (scanner.hasNextLine())
                Arrays.stream(scanner.nextLine().split(" "))
                        .mapToLong(Long::parseLong)
                        .forEach(stones::add);
        }
    }

    public long countStones(int blinkCount) {
        List<Long> stones = new ArrayList<>(this.stones);
        Map<Long, Long> stoneCountMap = new HashMap<>();
        for (Long stone : stones) {
            stoneCountMap.put(stone, stoneCountMap.getOrDefault(stone, 0L) + 1);
        }

        return blink(blinkCount, stoneCountMap);
    }

    private long blink(int blinkCount, Map<Long, Long> stoneCountMap) {
        Map<Long, List<Long>> stoneCache = new HashMap<>();
        for (int i = 0; i < blinkCount; i++) {
            Map<Long, Long> nextStoneCountMap = new HashMap<>();
            for (Map.Entry<Long, Long> stone : stoneCountMap.entrySet()) {
                List<Long> newStones = stoneCache.containsKey(stone.getKey())
                        ? stoneCache.get(stone.getKey())
                        : transform(stone.getKey(), stoneCache);
                for (Long newStone : newStones) {
                    nextStoneCountMap.put(
                            newStone,
                            nextStoneCountMap.getOrDefault(newStone, 0L) + stone.getValue());
                }
            }
            stoneCountMap = nextStoneCountMap;
        }

        return stoneCountMap.values().stream().mapToLong(stoneCount -> stoneCount).sum();
    }

    private List<Long> transform(Long stone, Map<Long, List<Long>> stoneCache) {
        String stoneString = String.valueOf(stone);
        if (stone == 0L) {
            stoneCache.put(stone, List.of(1L));
            return stoneCache.get(stone);
        }
        else if (stoneString.length() % 2 == 0) {
            int middle = stoneString.length() / 2;
            stoneCache.put(
                    stone,
                    List.of(
                            Long.parseLong(stoneString.substring(0, middle)),
                            Long.parseLong(stoneString.substring(middle))));
            return stoneCache.get(stone);
        } else {
            stoneCache.put(stone, List.of(stone * 2024L));
            return stoneCache.get(stone);
        }
    }
}