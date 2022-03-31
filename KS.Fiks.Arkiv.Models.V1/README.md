# Bruk av `KS.Fiks.Arkiv.Models.V1`

Pakken ligger på [nuget](https://www.nuget.org/) og kan installeres i prosjekt med `dotnet add package KS.Fiks.Arkiv.Models.V1`

## Eksempel

Modellene kan brukes direkte med import av namespace:
```csharp
using KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding;

var arkivmelding = new Arkivmelding
{
    ///...
};

```

Skjema er inkludert in nuget-pakken og kan refereres med refleksjon:

```csharp
// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding;

void ValidationHandler(object? _, ValidationEventArgs args)
{
    if (args.Severity == XmlSeverityType.Warning)
        Console.Write("WARNING: ");
    else if (args.Severity == XmlSeverityType.Error)
        Console.Write("ERROR: ");

    Console.WriteLine(args.Message);
}

var settings = new XmlReaderSettings
{
    ValidationType = ValidationType.Schema
};
settings.ValidationEventHandler += ValidationHandler;

var modelsAssemblyName = Assembly
    .GetExecutingAssembly()
    .GetReferencedAssemblies()
    .Single(x
        => "KS.Fiks.Arkiv.Models.V1".Equals(x.Name));

var modelsAssembly = Assembly
    .Load(modelsAssemblyName);

var schemaNames = modelsAssembly.GetManifestResourceNames();
foreach (var name in schemaNames)
{
    using var resourceStream = modelsAssembly.GetManifestResourceStream(name);
    using var streamReader = new StreamReader(resourceStream!);
    var xmlSchema = XmlSchema.Read(streamReader, ValidationHandler);
    settings.Schemas.Add(xmlSchema!);
}

var arkivmelding = new Arkivmelding
{
    //System = "system",
    MeldingId = "meldingId"
};
using var stream = new MemoryStream();
var serializer = new XmlSerializer(arkivmelding.GetType());
serializer.Serialize(stream, arkivmelding);
stream.Position = 0;

var reader = XmlReader.Create(stream, settings);
var doc = new XmlDocument();

//Vil printe melding med ERROR som sier at System er forventet i arkivobjektet
doc.Load(reader);
```
