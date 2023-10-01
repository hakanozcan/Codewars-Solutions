--8kyu
--https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/
-- # write your SQL statement here: you are given a table 'removechar' with column 's', return a table with column 's' and your result in a column named 'res'.

SELECT s, SUBSTRING(s, 2, LENGTH(s) - 2) AS res FROM removechar;
