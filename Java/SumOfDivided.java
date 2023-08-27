import java.util.*;
import java.util.stream.Collectors;


public class SumOfDivided {
    public static String sumOfDivided(int[] l) {
        Map<Integer, Integer> primeFactorSums = new TreeMap<>();
        
        for (int num : l) {
            List<Integer> primeFactors = primeFactors(num);
            
            for (int prime : primeFactors) {
                primeFactorSums.put(prime, primeFactorSums.getOrDefault(prime, 0) + num);
            }
        }
        
        StringBuilder result = new StringBuilder();
        for (Map.Entry<Integer, Integer> entry : primeFactorSums.entrySet()) {
            result.append("(").append(entry.getKey()).append(" ").append(entry.getValue()).append(")");
        }
        
        return result.toString();
    }

    private static List<Integer> primeFactors(int num) {
        List<Integer> factors = new ArrayList<>();
        int n = Math.abs(num);
        
        while (n % 2 == 0) {
            factors.add(2);
            n /= 2;
        }
        
        for (int i = 3; i <= Math.sqrt(n); i += 2) {
            while (n % i == 0) {
                factors.add(i);
                n /= i;
            }
        }
        
        if (n > 2) {
            factors.add(n);
        }
        
        return factors.stream().distinct().collect(Collectors.toList());
    }
}
