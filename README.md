# About the project
A file Backup Service using .NET which scans through specified directory by using the program's builtin File Watcher and save files such as *.pdf, *.docx, *.csv, *.xlsx, *.txt and *.json file to Google Drive. 

Generates an end-of-day report at 11:59am (UTC+8) of all the files that have been backed-up and send the report to an email. 
Generates and end-of-month report at the last day of the month, 11:59am (UTC+8) along with the end-of-day report to summarize all the report and send it to an email.

The recurring job would be implemented using Hangfire

This passion project would be added to the creator's portfolio to demonstrate ability to code using .NET 

# Project progress
- Create controllers for API endpoints
- Create data access layers via Repository and implement UnitOfWork

# TODO
- Add Query manager to execute raw SQL for complex query joining
- Add relevant data to the project (via database)
- Create the file watcher background job and scan the specified directory on the local system
- Implement moving of file from point A to point B (local system)
- Implement google drive API to copy from point A to google drive folder
- Add Hangfire to the project
- Implement end-of-day email report which attaches an excel file
- Implement end-of-month email report which attaches an excel file
- Add a Frontend using React + Remix for the controllers to have a user interface

# Example Database Scaffolding 
Scaffold-DbContext 'Data Source=DESKTOP-IHC6K02\MSSQLSERVER01;Initial Catalog=FileBackupService;Trusted_Connection=True;TrustServerCertificate=True;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model/BackupService -Context FileBackupServiceContext -force
