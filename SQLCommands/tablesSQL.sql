DROP TABLE IF EXISTS "Categories";
DROP TABLE IF EXISTS "Products";

create table "Categories"(
    "Id" integer GENERATED ALWAYS AS IDENTITY,    
    "Title" character varying(200) NOT NULL,
    CONSTRAINT categories_pkey PRIMARY KEY ("Id") 
);

create table "Products"(
    "Id" integer GENERATED ALWAYS AS IDENTITY,
    "Title" character varying(200) NOT NULL,    
    "Description" text,    
    "Price" decimal NOT NULL, 
    "CategoryId" integer NOT NULL,
    CONSTRAINT products_pkey PRIMARY KEY ("Id"),
    CONSTRAINT products_to_categories_fkey FOREIGN KEY ("CategoryId") REFERENCES "Categories"("Id")
);
