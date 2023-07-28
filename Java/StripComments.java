//4 kyu
//https://www.codewars.com/kata/51c8e37cee245da6b40000bd
import java.util.Arrays;
import java.util.stream.Collectors;

public class StripComments {

    public static String stripComments(String text, String[] commentSymbols) {
        String res = Arrays.stream(text.split("\n"))
                .map(line -> getStrippedLine(line, commentSymbols))
                .collect(Collectors.joining());

        return res.substring(0, res.lastIndexOf("\n"));
    }

    private static String getStrippedLine(String line, String[] commentSymbols) {
        int firstSymbolIndex = Integer.MAX_VALUE;

        for (String symbol : commentSymbols) {
            int currentSymbolIndex = line.indexOf(symbol);
            if (currentSymbolIndex >= 0)
                firstSymbolIndex = Math.min(firstSymbolIndex, currentSymbolIndex);
        }

        if (firstSymbolIndex == Integer.MAX_VALUE)
            return rightTrim(line) + "\n";
        return rightTrim(line.substring(0, firstSymbolIndex)) + "\n";
    }

    private static String rightTrim(String s) {
        int i = s.length() - 1;
        while (i >= 0 && Character.isWhitespace(s.charAt(i)))
            i--;

        return s.substring(0, i + 1);
    }
}