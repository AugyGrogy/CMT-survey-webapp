# Introduction
The purpose of this document is to express how to get started with the CTM Survey application.  The intent of the application is to manage and report on surveys sent to parents and instructors for the [Connecting Thru Misuc](https://connectingthrumusic.org/) Non-Profit.

# URLs:
- DEV: {enter-azure-website-here}

# Prerequisites
- [dotnet core 3.1](https://dotnet.microsoft.com/download)
- [sqllite](https://www.sqlite.org/download.html)
- [EF Core Tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
- [DBeaver](https://dbeaver.io/download/)

# Application Specific Getting Started
## Build the database
The database uses EF Core Migrations. The application uses IdentityServer4 and ASPNet Identity for authentication and authorization therefore there ar 2 DbContexts.  To build out the database blow away the contents of the Migrations folder and run the following commands.
- `dotnet-ef migrations add -c ctmsurveyContext --configuration DEBUG InitialMigration`
- `dotnet-ef database update -c ctmsurveyContext --configuration DEBUG` 
- `dotnet-ef migrations add -c CtmSurveyIdentityDbContext --configuration DEBUG IdentityMigration`
- `dotnet-ef database update -c CtmSurveyIdentityDbContext --configuration DEBUG`

* Run the application 
- `dotnet run --project ConnectingThruMusic`

# Test
* `dotnet test`