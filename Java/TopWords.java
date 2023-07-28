//4 kyu
//https://www.codewars.com/kata/51e056fe544cf36c410000fb

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.stream.Collectors;

public class TopWords {
    public static final int LIMIT = 3;
    private static final Pattern PATTERN = Pattern.compile("[A-Za-z][A-Za-z']*");

    public static List<String> top3(String string) {
        Map<String, Integer> wordsCount = new HashMap<>();
        Matcher matcher = PATTERN.matcher(string);
        while (matcher.find()) {
            String word = matcher.group().toLowerCase();
            wordsCount.put(word, wordsCount.getOrDefault(word, 0) + 1);
        }

        return wordsCount.entrySet().stream()
                .sorted(Map.Entry.<String, Integer>comparingByValue().reversed())
                .limit(LIMIT)
                .map(Map.Entry::getKey)
                .collect(Collectors.toList());
    }
}