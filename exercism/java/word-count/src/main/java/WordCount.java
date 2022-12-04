import java.util.HashMap;

public class WordCount {
    private final HashMap<String, Integer> dict;

    public WordCount() {
        dict = new HashMap<>();
    }

    public HashMap<String, Integer> phrase(String input) {
        int start = 0;
        boolean onLetter = false;
        for (int i = 0; i < input.length() - 1; i++) {
            if (Character.isLetter(input.charAt(i))) {
                onLetter = true;
                start = i;
            }
            else if (onLetter && Character.isWhitespace(input.charAt(i)))
                add(input, start, i);
            else
                onLetter = false;
        }

        return dict;
    }

    private void add(String input, int i, int j) {
        String key = input.substring(i, j);
        dict.put(key, dict.getOrDefault(key, 0));
    }
}
