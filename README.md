# Sber.SmartApp.Models

Models for Sber SmartApp API

Install
-------
It's available via [nuget package](https://www.nuget.org/packages/Sber.SmartApp.Models/)  
PM> `Install-Package Sber.SmartApp.Models`

## Migrating to 2.0

Use `System.Text.Json.JsonSerializer` to read a concrete `Request` or
`Response`. Both can still be written through `ContractBase` without a
type discriminator. Register any custom `ContractBase` subclasses in your
serializer's polymorphism configuration.

The models preserve the SmartApp field names and their casing. Set
`JsonSerializerOptions.PropertyNameCaseInsensitive` if your input can use
different casing. System.Text.Json applies its own JSON parsing and type
coercion rules.

## Build and test

Install the .NET SDK specified in `global.json`.

```sh
dotnet restore
dotnet build -c Release --no-restore
dotnet test -c Release --no-build
dotnet pack src/Sber.SmartApp.Models.csproj -c Release --no-build
```

## Release

Publish a GitHub Release from a commit that includes `release.yml` with a
new SemVer tag such as `2.1.0` or `v2.1.0-rc.1`. Omit build metadata because
NuGet excludes it from package identity. The workflow attaches the tested
package to the release and pushes it to both registries. Repository-wide
immutable releases must stay disabled for this upload after publication.

For NuGet.org, configure Trusted Publishing for owner `granstel`,
repository `Sber.SmartApp.Models`, workflow file `release.yml`, and
environment `nuget`. Set the environment secret `NUGET_USER` to the
NuGet.org profile name. If the package already exists on GitHub Packages,
grant this repository write access under the package's Actions settings.

Use **Re-run failed jobs** to resume a partial release with the same
package. Existing registry versions are skipped and an existing release
asset is accepted only if its digest matches.
