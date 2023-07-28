//5 kyu
//https://www.codewars.com/kata/5511b2f550906349a70004e1

import java.math.BigInteger;

public class Kata {
    public static int lastDigit(BigInteger n1, BigInteger n2) {
        int number = n1.mod(BigInteger.TEN).intValue();
        int reminder = n2.mod(BigInteger.valueOf(4)).intValue();

        if (n2.equals(BigInteger.ZERO))
            return 1;
        if (number == 5)
            return 5;
        if (number == 1)
            return 1;
        if (number == 0)
            return 0;
        if (number == 0 && n2.compareTo(BigInteger.ZERO) > 0)
            return 1;

        if (reminder == 0 && (number == 2 || number == 4 || number == 6 || number == 8)) {
            return 6;
        }
        if (reminder == 0 && (number == 3 || number == 7 || number == 9)) {
            return 1;
        }
        if (reminder != 0) {
            return (int) Math.pow(number, reminder) % 10;
        }

        return 0;
    }
}