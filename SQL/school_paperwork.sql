--8kyu
--https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd/
-- # write your SQL statement here: you are given a table 'paperwork' with columns 'id', 'n' and 'm', return a table with columns 'n', 'm' and your result in a column named 'res'.

SELECT n, m, GREATEST(n, 0) * GREATEST(m, 0) AS res FROM paperwork;