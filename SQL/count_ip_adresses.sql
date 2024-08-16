--5 kyu
--https://www.codewars.com/kata/526989a41034285187000de4

SELECT 
    id, 
    (
        (CAST(SPLIT_PART(last, '.', 1) AS bigint) * 256 * 256 * 256 +
         CAST(SPLIT_PART(last, '.', 2) AS bigint) * 256 * 256 +
         CAST(SPLIT_PART(last, '.', 3) AS bigint) * 256 +
         CAST(SPLIT_PART(last, '.', 4) AS bigint)) 
         - 
        (CAST(SPLIT_PART(first, '.', 1) AS bigint) * 256 * 256 * 256 +
         CAST(SPLIT_PART(first, '.', 2) AS bigint) * 256 * 256 +
         CAST(SPLIT_PART(first, '.', 3) AS bigint) * 256 +
         CAST(SPLIT_PART(first, '.', 4) AS bigint))
    ) AS ips_between
FROM 
    ip_addresses;
