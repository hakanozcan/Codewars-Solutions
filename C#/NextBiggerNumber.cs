//4 kyu
//https://www.codewars.com/kata/55983863da40caa2c900004e

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
     public static long NextBiggerNumber(long n)
        {
            static string Nums(long num) => string.Concat(num.ToString().OrderByDescending(i => i));
            var num = Nums(n);
            if (num == n.ToString()) return -1;
            do
            {
                n++;
            } while (Nums(n) != num);

            return n;
        }
}