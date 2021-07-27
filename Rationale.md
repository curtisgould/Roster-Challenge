Used C# ASP.Net Core with code first Entity Framework for database
I chose this both because I love working in C# and I wanted to use this as an opportunity to enhance my  skills in .Net Core and database migrations which I know make maintaining the database extremely easy, which would be beneficial to whoever ends up running this solution.

I started out by creating the model which would create the database based on the JSON file provided. I then chose to load the data into the database manually with a script, I considered creating an ingestion point as part of the website in case there were ever a need to bulk upload more information however chose to do it manually for now as this didn't seem like something the client would want to do often, if they did it would be something which could be enhanced down the line.

After the data was loaded I proceeded to query the data from the database, creating functions in the model to calculate the totals owed, i did this for two reasons:
1. Performing calculations in the model helps ensure database normalization which improves data integrity.
2. Minimizing code complexity reduces time/effort spent on future changes.

Created CRUD functionality using modals for add/edit and ajax calls for all functionality so that the user does not need to redirect to perform every action on the page. When making the controllers, made all CRUD functions in a way which they could be easily adapted into a complete restful API should there ever be a need to create one.

Added confirm boxes for marking artists as paid and for deleting artists to prevent user error; future enhancements could be change history logging and individual user accounts for audit purposes.

Added table sorter to help users find specific artists more efficiently.

Made body of the table the only part of the page that scrolls, makes determining which headers are which easier 
