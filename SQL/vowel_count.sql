--7kyu
--https://www.codewars.com/kata/54ff3102c1bad923760001f3/
-- # write your SQL statement here: you are given a table 'getcount' with column 'str', return a table with column 'str' and your result in a column named 'res'.

SELECT str,
       LENGTH(str) - LENGTH(TRANSLATE(str, 'aeiou', '')) AS res
FROM getcount;
