/* You will need to download 'adventure-works-2008r2-lt.bak' from https://github.com/Microsoft/sql-server-samples/releases */
RESTORE DATABASE AdventureWorksLT2008
FROM DISK = 'C:\Samples\adventure-works-2008r2-lt.bak' -- You can change this to the filepath that you are using

WITH MOVE 'AdventureWorksLT2008_Data' TO 'C:\Samples\adventure-works-2008r2-lt.mdf',
MOVE 'AdventureWorksLT2008_Log' TO 'C:\Samples\adventure-works-2008r2-lt.ldf',
REPLACE;