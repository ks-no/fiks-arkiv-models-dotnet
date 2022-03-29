# Bruk av `KS.Fiks.Arkiv.Models.V1`

## Genererte klasser

Etter at nuget er inkludert i prosjekt er klassene tilgjengelig ved:

```csharp
using KS.Fiks.IO.Arkiv.Models.Arkivstruktur;

var arkiv = new Arkiv();
```

## XSD skjema

Skjema er inkludert in nuget-pakken og kan refereres med refleksjon:

```csharp
using System.Reflection;

var referencesAssemblies = Assembly
    .GetExecutingAssembly()
    .GetReferencedAssemblies();

var modelsAssemblyName = referencesAssemblies
    .Single(x
        => "KS.Fiks.Arkiv.Models.V1".Equals(x.Name));

using var arkivStream = Assembly.Load(modelsAssemblyName)
    .GetManifestResourceStream("KS.Fiks.Arkiv.Models.V1.Schema.arkivmelding.xsd");

using var reader = new StreamReader(arkivStream);

var arkivXsd = reader.ReadToEnd();

Console.WriteLine(arkivXsd);
```
