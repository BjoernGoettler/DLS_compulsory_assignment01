USE common;
CREATE TABLE Logs(
                    Id int auto_increment,
                    Timestamp datetime default now(),
                    LogLevel TEXT,
                    LogMessage TEXT,
                    primary key(Id)
);