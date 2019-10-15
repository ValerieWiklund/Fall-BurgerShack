USE burgershackvw;


-- CREATE TABLE burgers
-- (
--   id VARCHAR(255) NOT NULL,
--   name VARCHAR(255) NOT NULL,
--   price DECIMAL(5, 2) DEFAULT .99,
--   description VARCHAR(255) NOT NULL,

--   PRIMARY KEY(id)
-- )

-- Create

-- INSERT INTO burgers
--   (id, name, price, description)
-- VALUES
--   ("235", "D$", 12.99, "All the meat and cheese we have");

--   -- Get all

--   SELECT * FROM burgers;


-- get by (Find)
-- SELECT * FROM burgers WHERE  id = 123;


-- -- edit
-- UPDATE burgers
-- SET name = "Aloha Zach"
-- WHERE id = 123;

-- SELECT *
-- FROM burgers;

-- DROP TABLE BURGERS  This completely deletes the burger table.

-- DELETE

DELETE FROM burgers WHERE id = 235;
SELECT *
FROM burgers;