Install Package 
> dotnet new webapi -o buildingapi
> dotnet add package Microsoft.EntityFrameworkCore -v 3.1.10
> dotnet add package Microsoft.EntityFrameworkCore.Design -v 3.1.10
> dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.10
> dotnet add package MySql.EntityFrameworkCore -v 3.1.10+m8.0.23
-- > dotnet add package Devart.Data.MySql.EFCore
> dotnet tool install --global dotnet-ef
> dotnet ef -h (check if ef tools is installed)



Remove a package
> dotnet remove package  Microsoft.EntityFrameworkCore.Tools

Check package version
> dotnet list package

Generate model from data base
> dotnet ef dbcontext scaffold "Server=localhost;port=3306;Database=MaximeAuger_mysql;uid=root;password=emmanuel" MySql.EntityFrameworkCore -o Model


Reference:
https://docs.microsoft.com/en-us/ef/core/cli/dotnet


