//4 kyu
//https://www.codewars.com/kata/52742f58faf5485cae000b9a

import java.util.Arrays;
import java.util.List;
import java.util.Objects;

import static java.util.stream.Collectors.toList;

public class TimeFormatter {

    

    public static String formatDuration(int seconds) {
        if (seconds == 0) return "now";
        int years = seconds / 31556952;
        int days = (seconds / 86400) % 365;
        int hours = (seconds / 3600) % 24;
        int minutes = (seconds / 60) % 60;
        int sec = seconds % 60;

        return formatWholeDate(Arrays.asList(
                formatTime(years, "year"),
                formatTime(days, "day"),
                formatTime(hours, "hour"),
                formatTime(minutes, "minute"),
                formatTime(sec, "second")
        ));
    }

    private static String formatWholeDate(List<String> times) {
        List<String> fTimes = times.stream().filter(Objects::nonNull).collect(toList());

        if (fTimes.size() == 1)
            return fTimes.get(0);
        if (fTimes.size() == 2)
            return fTimes.get(0) + " and " + fTimes.get(1);
        if (fTimes.size() >= 3) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < fTimes.size() - 2; i++) {
                sb.append(fTimes.get(i)).append(", ");
            }
            sb.append(fTimes.get(fTimes.size() - 2)).append(" and ").append(fTimes.get(fTimes.size() - 1));
            return sb.toString();
        }
        return "";
    }

    private static String formatTime(int time, String unit) {
        if (time == 0) return null;
        String result = time + " " + unit;
        return time == 1 ? result : result + "s";
    }
}