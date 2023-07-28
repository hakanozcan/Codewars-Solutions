//4 kyu
//https://www.codewars.com/kata/5324945e2ece5e1f32000370
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata {
  public static string sumStrings(string a, string b)
        {
            var builder = new StringBuilder();
            var maxLength = Math.Max(a.Length, b.Length);
            var remainder = 0;

            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            for (var index = maxLength - 1; index >= 0; index--)
            {
                var sum = a[index] - 48 + b[index] - 48 + remainder;
                builder.Insert(0, sum % 10);
                remainder = sum / 10;

                if (index == 0) builder.Insert(0, remainder);
            }

            return string.Join("", builder.ToString().TrimStart('0'));
        }
}