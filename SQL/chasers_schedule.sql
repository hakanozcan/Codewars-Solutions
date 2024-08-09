--6 kyu
--https://www.codewars.com/kata/628df6b29070907ecb3c2d83/train/sql

SELECT s, t, s * (t - 2 * n) + 3 * n * (2 * s - n + 1) / 2 res
FROM speedandtime, LEAST((t + 1) / 2, (s - 2 *  s / 3)) n