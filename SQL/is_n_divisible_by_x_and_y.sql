--8kyu
--https://www.codewars.com/kata/5545f109004975ea66000086/
-- You will be given a table 'kata' with columns 'id', 'n', 'x', and 'y'. 
-- Return the 'id' and your result in a column named 'res' using a SELECT statement.
-- You DON'T need to create a function, that's for other languages.

SELECT ID, MOD(n, x) = 0 AND MOD(n, y) = 0 AS res FROM kata;