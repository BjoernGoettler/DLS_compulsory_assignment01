USE common;
CREATE TABLE Log(
                    Id int primary key,
                    Timestamp datetime,
                    LogLevel TEXT,
                    Message TEXT
);