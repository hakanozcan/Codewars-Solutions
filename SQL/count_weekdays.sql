--5 kyu
--https://www.codewars.com/kata/58241d05e7a162c5b100010f/train/sql/66b4e1dd80f28bfcb1c5e9ed

CREATE OR REPLACE FUNCTION weekdays(start_date DATE, end_date DATE)
RETURNS INTEGER AS $$
DECLARE
    num_weekdays INTEGER := 0;
    current_date DATE;
BEGIN   
    IF start_date > end_date THEN        
        current_date := start_date;
        start_date := end_date;
        end_date := current_date;
    END IF;
   
    current_date := start_date;
    
    WHILE current_date <= end_date LOOP        
        IF EXTRACT(dow FROM current_date) BETWEEN 1 AND 5 THEN
            num_weekdays := num_weekdays + 1;
        END IF;     
        current_date := current_date + INTERVAL '1 day';
    END LOOP;

    RETURN num_weekdays;
END;
$$ LANGUAGE plpgsql;
