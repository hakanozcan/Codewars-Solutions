--8kyu
--https://www.codewars.com/kata/57eae65a4321032ce000002d/
-- # write your SQL statement here: you are given a table 'fakebin' with column 'x', return a table with column 'x' and your result in a column named 'res'.

SELECT
  x,
  TRANSLATE(x, '0123456789', '0000011111') AS res
FROM fakebin;
