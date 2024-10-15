USE common;
CREATE TABLE Logs(
                    Id int auto_increment,
                    Timestamp datetime default now(),
                    LogLevel TEXT,
                    Message TEXT,
                    primary key(Id)
);