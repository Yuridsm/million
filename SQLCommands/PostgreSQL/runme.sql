DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;

/*
 * SQL for database PostgreSQL
*/

CREATE TABLE logs (
    log_identifier serial PRIMARY KEY,
    title varchar(64)
    description text,
    log_time timestamp with time zone NOT NULL DEFAULT current_timestamp
);

create table Categories (
    Identifier serial PRIMARY KEY,    
    Title varchar(65) NOT NULL
);

create table Products (
    Identifier serial PRIMARY KEY,
    Title varchar(64) NOT NULL,    
    Description text,    
    Price decimal NOT NULL,
    CategoryIdentifier serial
);

ALTER TABLE Products ADD CONSTRAINT fk_products_01 
FOREIGN KEY (CategoryIdentifier)
REFERENCES Categories (Identifier)
ON UPDATE CASCADE ON DELETE RESTRICT;
