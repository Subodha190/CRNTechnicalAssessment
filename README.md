CRN Technical Assessment API

Overview

- Project: CRNTechnicalAssessment
- Purpose: Simple product API with JWT authentication and Swagger documentation.
- Projects:
  - `Api` - ASP.NET Core Web API (startup project)
  - `Application` - Application-level interfaces/DTOs
  - `Infrastructure` - Data access, EF Core DbContext and repositories

Platform

- .NET Target: .NET 10
- C# Version: 14
- Packages: Swashbuckle (Swagger), EF Core, FluentValidation, Serilog, JWT bearer auth

Prerequisites

- .NET 10 SDK installed: https://dotnet.microsoft.com/
- SQL Server instance available (local or remote)
- Optional: dotnet-ef tool for migrations (`dotnet tool install --global dotnet-ef`)

Configuration

- Connection string is in `Api/appsettings.json` under `ConnectionStrings:DefaultConnection`.
  - Default example: `Server=YOUR_SERVER;Database=CRNAssessmentDB;Trusted_Connection=True;TrustServerCertificate=True`
  - Update server name / credentials as needed.

- JWT settings are in `Api/appsettings.json` under the `Jwt` section. Keep the `Key` secret for production.

Running locally

1. Restore packages and build
   - From repository root:
     - `dotnet restore` 
     - `dotnet build`

2. Database (optional)
   - If you have migrations and want to create the database:
     - Install EF tools if needed: `dotnet tool install --global dotnet-ef`
     - Create or apply migrations from the solution root (example):
       - `dotnet ef migrations add Initial --project Infrastructure --startup-project Api`
       - `dotnet ef database update --project Infrastructure --startup-project Api`
   - Alternatively create the database manually and ensure the connection string points to it.

3. Run the API
   - From `Api` folder or solution root targeting the Api project:
     - `dotnet run --project Api`
   - In Visual Studio, set `Api` as the startup project and run (F5).

Swagger / API documentation

- Swagger UI is enabled and configured in `Api/Program.cs`.
- By default Swagger UI is served at the application root (i.e. `/`) because `RoutePrefix` is set to empty.
  - If your browser opens the root and you don't see Swagger, try `/swagger` or `/swagger/index.html`.
- You can change Visual Studio launch URL in `Api/Properties/launchSettings.json` by setting `launchUrl` to `swagger`.

Authentication

- Basic JWT login endpoint (development demo):
  - `POST /api/v1/auth/login` with JSON body:
    - `{ "username": "admin", "password": "admin123" }`
  - Returns a JWT token in the response body: `{ "token": "<jwt>" }`
- Protect other endpoints by adding `Authorization: Bearer <token>` header.

Common issues & troubleshooting

- `Swagger not opening on browser startup`:
  - Ensure `Api` is the startup project and `launchUrl` is configured or Swagger is served at `/`.

- `OpenApi / Swashbuckle` type not found errors:
  - Run `dotnet restore` to ensure NuGet packages are installed.
  - Confirm `Swashbuckle.AspNetCore` is referenced in `Api/Api.csproj`.

- `Database connection` problems:
  - Verify the connection string in `Api/appsettings.json` and that SQL Server is reachable.

Security note

- The demo login (`admin` / `admin123`) and the JWT key in `appsettings.json` are for development only. Replace with secure values for production and never commit real secrets to source control.

Extending

- Add controllers in `Api/Controllers`.
- Implement domain models and EF mappings in `Infrastructure` and service logic in `Application`.

Contact

- Repository origin: https://github.com/Subodha190/CRNTechnicalAssessment

License

- No license specified in this repository. Add a LICENSE file if you intend to make the code public with a license.
CRN Technical Assessment API

Overview

- Project: CRNTechnicalAssessment
- Purpose: Simple product API with JWT authentication and Swagger documentation.
- Projects:
  - `Api` - ASP.NET Core Web API (startup project)
  - `Application` - Application-level interfaces/DTOs
  - `Infrastructure` - Data access, EF Core DbContext and repositories

Platform

- .NET Target: .NET 10
- C# Version: 14
- Packages: Swashbuckle (Swagger), EF Core, FluentValidation, Serilog, JWT bearer auth

Prerequisites

- .NET 10 SDK installed: https://dotnet.microsoft.com/
- SQL Server instance available (local or remote)
- Optional: dotnet-ef tool for migrations (`dotnet tool install --global dotnet-ef`)

Configuration

- Connection string is in `Api/appsettings.json` under `ConnectionStrings:DefaultConnection`.
  - Default example: `Server=YOUR_SERVER;Database=CRNAssessmentDB;Trusted_Connection=True;TrustServerCertificate=True`
  - Update server name / credentials as needed.

- JWT settings are in `Api/appsettings.json` under the `Jwt` section. Keep the `Key` secret for production.

Running locally

1. Restore packages and build
   - From repository root:
     - `dotnet restore` 
     - `dotnet build`

2. Database (optional)
   - If you have migrations and want to create the database:
     - Install EF tools if needed: `dotnet tool install --global dotnet-ef`
     - Create or apply migrations from the solution root (example):
       - `dotnet ef migrations add Initial --project Infrastructure --startup-project Api`
       - `dotnet ef database update --project Infrastructure --startup-project Api`
   - Alternatively create the database manually and ensure the connection string points to it.

3. Run the API
   - From `Api` folder or solution root targeting the Api project:
     - `dotnet run --project Api`
   - In Visual Studio, set `Api` as the startup project and run (F5).

Swagger / API documentation

- Swagger UI is enabled and configured in `Api/Program.cs`.
- By default Swagger UI is served at the application root (i.e. `/`) because `RoutePrefix` is set to empty.
  - If your browser opens the root and you don't see Swagger, try `/swagger` or `/swagger/index.html`.
- You can change Visual Studio launch URL in `Api/Properties/launchSettings.json` by setting `launchUrl` to `swagger`.

Authentication

- Basic JWT login endpoint (development demo):
  - `POST /api/v1/auth/login` with JSON body:
    - `{ "username": "admin", "password": "admin123" }`
  - Returns a JWT token in the response body: `{ "token": "<jwt>" }`
- Protect other endpoints by adding `Authorization: Bearer <token>` header.

Common issues & troubleshooting

- `Swagger not opening on browser startup`:
  - Ensure `Api` is the startup project and `launchUrl` is configured or Swagger is served at `/`.

- `OpenApi / Swashbuckle` type not found errors:
  - Run `dotnet restore` to ensure NuGet packages are installed.
  - Confirm `Swashbuckle.AspNetCore` is referenced in `Api/Api.csproj`.

- `Database connection` problems:
  - Verify the connection string in `Api/appsettings.json` and that SQL Server is reachable.

Security note

- The demo login (`admin` / `admin123`) and the JWT key in `appsettings.json` are for development only. Replace with secure values for production and never commit real secrets to source control.

Extending

- Add controllers in `Api/Controllers`.
- Implement domain models and EF mappings in `Infrastructure` and service logic in `Application`.

Contact

- Repository origin: https://github.com/Subodha190/CRNTechnicalAssessment

License

- No license specified in this repository. Add a LICENSE file if you intend to make the code public with a license.
