# VibeCodingTrailer

Clean-Architecture sample solution (.NET 10) containing Application, Domain, Infrastructure (Persistence) and Presentation (API) projects.

Quick start

- Build: `dotnet build`
- Run API: `dotnet run --project Presentation/VibeCodingTrailer.Api/VibeCodingTrailer.Api.csproj --configuration Debug`
- When running from Visual Studio the launch profile is configured to open Swagger at `/swagger`.

Project structure

- `Application/` – application layer projects
- `Domain/` – domain models (e.g. `Product`)
- `Infrastructure/` – persistence implementation (dummy `ProductService`)
- `Presentation/` – `VibeCodingTrailer.Api` (ASP.NET Core Web API)

Notes

- Swagger UI is served at `/swagger` and a `ProductsController` with a dummy `GET /api/products` endpoint is included.
- Some temporary build settings were added to `Directory.Build.props` to avoid Roslyn/ICU memory issues in the current environment. See `INSTRUCTION.md` for details.
