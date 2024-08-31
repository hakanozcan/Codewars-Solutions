--5 kyu
--https://www.codewars.com/kata/5977b6641e250a661a0000f0

SELECT
    event_time AS when_happened,
    current_visits AS visits_count
FROM (
    SELECT
        event_time,
        SUM(change) OVER (ORDER BY event_time ASC) AS current_visits
    FROM (
        SELECT entry_time AS event_time, 1 AS change
        FROM visits
        UNION ALL
        SELECT exit_time AS event_time, -1 AS change
        FROM visits
    ) AS events
) AS cumulative_visits
ORDER BY current_visits DESC, event_time ASC
LIMIT 1;
