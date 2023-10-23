--CREATE DATABASE habrdb;
CREATE TABLE Users (
  id SERIAL PRIMARY KEY,
  age INT,
  pass varchar(50),
  first_name TEXT,
  last_name TEXT
);