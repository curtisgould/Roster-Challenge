# Roster-Challenge

Dependencies: SQL Server, Visual Studio

How to run this project:

1. Pull git repository
2. Open solution for Roster-Challenge 
3. Open Package Manager Console in visual studio ( View > Other Windows > Package Manager Console )
4. Run the following commands in the package manager console to create a Roster database: update-database
5. Run the following SQL against your SQL Server Roster database to import your JSON file (update the script to your local filepath)
			
```SQL
Declare @JSON varchar(max)

SELECT @JSON=BulkColumn
FROM OPENROWSET (BULK 'YOUR FILE PATH TO Roster.JSON', SINGLE_CLOB) import

SELECT @JSON=[value] FROM OPENJSON (@JSON)

INSERT INTO Artists
SELECT *, 0 FROM OPENJSON (@JSON)
WITH 
(
	[artist] nvarchar(MAX), 
	[rate] float, 
	[streams] int
)
```
6. Run your solution in visual studio
