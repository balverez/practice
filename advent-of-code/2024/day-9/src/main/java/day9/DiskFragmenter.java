package day9;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.util.stream.IntStream;

public class DiskFragmenter {
    private int[] diskMap;
    private Map<Integer, Integer> fileSizeMap = new HashMap<>();
    private Map<Integer, Integer> fileLocationMap = new HashMap<>();

    public DiskFragmenter(String inputPath) throws FileNotFoundException {
        try (Scanner scanner = new Scanner(new File(inputPath))) {
            if (scanner.hasNextLine()) {
                char[] diskMapArray = scanner.nextLine().toCharArray();

                diskMap = IntStream.range(0, diskMapArray.length)
                        .map(i -> Integer.parseInt(String.valueOf(diskMapArray[i]))).toArray();
            }
        }
    }

    public long checksum() {
        String[] disk = mapDisk();
        compact(disk);

        return checksum(disk);
    }

    public long checksumWithWholeFileCompression() {
        String[] disk = mapDisk();
        compactWholeFiles(disk);

        return checksum(disk);
    }

    private String[] mapDisk() {
        String[] disk;
        int diskSpace = 0;
        for (int i : diskMap)
            diskSpace += i;

        disk = new String[diskSpace];
        int id = 0;
        int j = 0;
        for (int i = 0; i < diskMap.length; i++) {
            int k = diskMap[i];
            for (int l = 0; l < k; l++)
                if (i % 2 == 1)
                    disk[j++] = ".";
                else{
                    fileLocationMap.putIfAbsent(id, j);
                    disk[j++] = Integer.toString(id);
                }

            if (i % 2 == 0){
                fileSizeMap.put(id, k);
                id++;
            }
        }

        return disk;
    }

    private void compact(String[] disk) {
        int i = 0;
        int j = disk.length - 1;
        while (i < j) {
            if (!disk[i].equals(".")) {
                i++;
                continue;
            }

            while (disk[j].equals(".")) {
                j--;
            }
            if (i < j) {
                disk[i++] = disk[j];
                disk[j--] = ".";
            }
        }
    }

    private void compactWholeFiles(String[] disk) {
        List<Integer> keys = new ArrayList<>(fileSizeMap.keySet().stream().sorted().toList());
        int i = 0;
        for (int l = keys.size() - 1; l > 0; l--) {
            while (i < fileLocationMap.get(keys.get(l))) {
                while (i < fileLocationMap.get(keys.get(l)) && !disk[i].equals("."))
                    i++;

                int k = i;
                while (k < disk.length && disk[k].equals("."))
                    k++;

                if (k < disk.length) {
                    int freeCapacity = k - i;
                    if (fileSizeMap.get(keys.get(l)) <= freeCapacity) {
                        IntStream
                                .range(
                                        fileLocationMap.get(keys.get(l)),
                                        fileLocationMap.get(keys.get(l)) + fileSizeMap.get(keys.get(l)))
                                .forEach(n -> disk[n] = ".");

                        for (int m = i; m < i + fileSizeMap.get(keys.get(l)); m++)
                            disk[m] = keys.get(l).toString();

                        break;
                    } else
                        i = k;
                }
            }
            keys.remove(l);
            i = 0;
        }
    }

    private long checksum(String[] disk) {
        long checksum = 0;
        for (int i = 0; i < disk.length; i++)
            checksum += (long) i * (disk[i].equals(".") ? 0 : Integer.parseInt(disk[i]));

        return checksum;
    }
}