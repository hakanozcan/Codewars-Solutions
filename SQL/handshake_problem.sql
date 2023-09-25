--6kyu
--https://www.codewars.com/kata/5574835e3e404a0bed00001b
--# write your SQL statement here: 
-- you are given a table 'participants' with column 'n' (number of handshakes).
-- return a table with this column and your result in a column named 'res'.

SELECT n,
       CASE WHEN n = 0 THEN 0
            ELSE CAST(CEIL(0.5 * (SQRT(8 * n + 1) + 1)) AS INTEGER)
       END AS res
FROM participants;

