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
