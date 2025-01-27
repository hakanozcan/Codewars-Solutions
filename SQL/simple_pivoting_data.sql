--5kyu
--https://www.codewars.com/kata/58126aa90ea99769e7000119/

CREATE EXTENSION tablefunc;

SELECT *
FROM crosstab(
    $$
    SELECT
        p.name, 
        d.detail, 
        COUNT(d.id) AS count
    FROM
        products p
    JOIN
        details d
    ON
        p.id = d.product_id
    GROUP BY
        p.name, d.detail
    ORDER BY
        p.name, d.detail
    $$,
    $$ VALUES ('bad'), ('good'), ('ok') $$
) AS ct(name TEXT, bad BIGINT, good BIGINT, ok BIGINT);
