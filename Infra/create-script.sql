-- CREATE TABLE IF NOT EXISTS peoples (
--   id UUID PRIMARY KEY,
--   name VARCHAR(100) UNIQUE NOT NULL,
--   nickname VARCHAR(32) NOT NULL,
--   birth DATE NOT NULL,
--   stack TEXT NULL,
--   search TEXT GENERATED ALWAYS AS (name || ' ' || nickname) STORED
-- )

CREATE TABLE IF NOT EXISTS peoples (
  id UUID PRIMARY KEY,
  name VARCHAR(100) UNIQUE NOT NULL,
  nickname VARCHAR(32) NOT NULL,
  birth DATE NOT NULL,
  stack TEXT[] NULL,
  search TEXT GENERATED ALWAYS AS (name || ' ' || nickname || '' || stack) STORED
);