//6 kyu
//https://www.codewars.com/kata/54da5a58ea159efa38000836  
import java.util.HashMap;
import java.util.Map;

public class FindOdd {
	public static int findIt(int[] a) {
  	HashMap<Integer, Integer> map = new HashMap<>();
        for (int number : a) {
            int count = map.getOrDefault(number, 0);
            map.put(number, count + 1);
        }
        for (Map.Entry<Integer, Integer> entry : map.entrySet()) {
            if (entry.getValue() % 2 != 0) return entry.getKey();
        }
        return 0;
  }
}