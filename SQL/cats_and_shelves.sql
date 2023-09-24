--7kyu
--https://www.codewars.com/kata/62c93765cef6f10030dfa92b/
--# write your SQL statement here: 
-- you are given a table 'jumps' with columns 'a' (start) and 'b' (finish).
-- return a table with:
--   these columns and your result in a column named 'res'

SELECT a,
       b,
       ((b - a) / 3)::INTEGER + ((b - a) % 3) AS res
FROM jumps;
