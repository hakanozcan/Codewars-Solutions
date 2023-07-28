//4 kyu
//https://www.codewars.com/kata/52ec24228a515e620b0005ef

const memo = [];

function sum(n, m = n) {
  if (n === 0) return 1;
  if (n < 0 || m === 0) return 0;
  if (!memo[n]) memo[n] = [];
  if (memo[n][m]) return memo[n][m];

  const total = sum(n, m - 1) + sum(n - m, m);
  memo[n][m] = total;
  return total;
}