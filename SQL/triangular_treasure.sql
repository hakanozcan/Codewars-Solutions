--7kyu
--https://www.codewars.com/kata/525e5a1cb735154b320002c8/
--# write your SQL statement here: 
-- you are given a table 'triangular' with column 'n'
-- return a table with this column and your result in a column named 'res'.

SELECT n, 
CASE
    WHEN n > 0 THEN CEIL((n + 1) * n / 2)::BIGINT
    ELSE 0
END
AS res FROM triangular;

