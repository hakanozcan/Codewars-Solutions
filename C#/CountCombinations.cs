//4kyu
//https://www.codewars.com/kata/541af676b589989aed0009e7
using System;
using System.Linq;
public static class Kata
{
   public static int CountCombinations(int money, int[] coins)
{
     return (money < 0 || !coins.Any()) ? 0 : (money == 0) ? 1 : CountCombinations(money - coins[0], coins) + CountCombinations(money, coins.Skip(1).ToArray());
}
}