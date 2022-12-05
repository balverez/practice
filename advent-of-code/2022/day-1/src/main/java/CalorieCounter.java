import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.nio.file.NoSuchFileException;
import java.util.LinkedList;
import java.util.PriorityQueue;

public class CalorieCounter {

    public int count(File file, int topCount) {
        PriorityQueue<Integer> minHeap = new PriorityQueue<>();

        try (BufferedReader reader = new BufferedReader(new FileReader(file))) {
            String line = reader.readLine();
            while (line != null) {
                int sum = 0;
                while (line != null && !line.equals("")) {
                    int calories = Integer.parseInt(line);
                    sum += calories;
                    line = reader.readLine();
                }

                minHeap.add(sum);
                if (minHeap.size() > topCount) {
                    minHeap.poll();
                }

                line = reader.readLine();
            }
        } catch (NoSuchFileException ex) {
            return -1;
        } catch (Exception ex) {
            return -2;
        }

        int calorieSum = 0;
        while (minHeap.size() > 0) {
            calorieSum += minHeap.poll();
        }

        return calorieSum;
    }
}
