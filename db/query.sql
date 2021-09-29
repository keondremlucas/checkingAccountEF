DROP TABLE CheckingAccounts;
DROP TABLE Bank;

CREATE TABLE CheckingAccounts (
    Id integer PRIMARY KEY AUTOINCREMENT,
    Owner varchar(10),
    Balance integer
);

CREATE TABLE Bank (
    Id integer PRIMARY KEY AUTOINCREMENT,
    receipt varchar(20)
   
);