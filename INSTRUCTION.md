INSTRUCTION - VibeCodingTrailer

Summary of changes made so far

1. Solution created with a Clean Architecture layout (Application, Domain, Infrastructure, Presentation).
2. Projects added:
   - `VibeCodingTrailer.Domain` (Domain) — contains `Product` record.
   - `VibeCodingTrailer.Application.Abstraction` (Application.Abstraction) — declares `IProductService`.
   - `VibeCodingTrailer.Application` (Application) — references Abstraction.
   - `VibeCodingTrailer.Persistence` (Infrastructure) — provides `ProductService` implementing `IProductService` and references Domain & Application.Abstraction.
   - `VibeCodingTrailer.Api` (Presentation) — ASP.NET Core Web API, references Application and Persistence.
3. Fixed compilation errors by adding a `ProjectReference` from `Application.Abstraction` to `Domain` so `IProductService` can reference `Product`.
4. Added a simple `ProductsController` in the API project with a dummy `GET /api/products` endpoint.
5. Configured Swagger (Swashbuckle) in `Program.cs` and set `launchSettings.json` to open Swagger at `/swagger` when launching.
6. Added `Directory.Build.props` to reduce build-time memory pressure and avoid Roslyn/ICU failures in this environment:
   - Disabled parallel build and shared compilation.
   - Disabled analyzers during build and live analysis.
   - Enabled `InvariantGlobalization`.

Files added/modified

- Modified: `Application/VibeCodingTrailer.Application.Abstraction/VibeCodingTrailer.Application.Abstraction.csproj` (added ProjectReference to Domain)
- Modified: `Presentation/VibeCodingTrailer.Api/Program.cs` (added controllers & Swagger setup)
- Modified: `Presentation/VibeCodingTrailer.Api/Properties/launchSettings.json` (set launchUrl to `swagger` and enable browser launch)
- Added: `Presentation/VibeCodingTrailer.Api/Controllers/ProductsController.cs` (dummy endpoint)
- Added: `Directory.Build.props` (build-time workarounds)
- Added: `README.md` and `INSTRUCTION.md`

How to run locally

1. Ensure .NET 10 SDK is installed.
2. Restore and build the solution:
   - `dotnet build`
3. Run the API project:
   - `dotnet run --project Presentation/VibeCodingTrailer.Api/VibeCodingTrailer.Api.csproj --configuration Debug`
4. In a browser open:
   - `http://localhost:5082/swagger` (or the HTTPS URL shown in console). If running from Visual Studio, the launch profile will open Swagger automatically.

Notes and next steps

- The `Directory.Build.props` file contains build-time workarounds for the current environment (disabling analyzers, enabling invariant globalization). Consider removing or reverting these settings in a stable development environment.
- Next features to implement on branch `hekanemre/<yyyymmdd>/entitychanges`:
  - Add EF Core packages and `ApplicationDbContext` in Persistence.
  - Wire `ProductsController` to `IProductService` via DI.
  - Add DTOs and mapping.

