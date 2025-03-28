# KS.Fiks.Arkiv.Models.V1

## Github repositories

### fiks-arkiv-models-dotnet
Dette er prosjektet som genererer denne koden fra spesification prosjektet

https://github.com/ks-no/fiks-arkiv-models-dotnet

[Releases](https://github.com/ks-no/fiks-arkiv-models-dotnet/releases)

### fiks-arkiv-specification
Dette er prosjektet hvor selve spesifikasjonen med xsd-skjema og meldingstyper er definert.

Det er definisjonen av Fiks Arkiv protokollen.

https://github.com/ks-no/fiks-arkiv-specification

[Releases](https://github.com/ks-no/fiks-arkiv-specification/releases)

##  Bruk av modellene

Modellene kan brukes direkte med import av namespace:

```csharp
using KS.Fiks.Arkiv.Models.V1.Arkivering.Arkivmelding;
using KS.Fiks.Arkiv.Models.V1.Kodelister;

var arkivmelding = new Arkivmelding
{
    ///...
};

var sendtTilbakeKode = FlytStatusKoder.SendtTilbake.Verdi;

```

Skjema er inkludert in nuget-pakken og kan refereres med refleksjon:

```csharp
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

var modelsAssembly = Assembly
    .Load("KS.Fiks.Arkiv.Models.V1");

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

//Vil printe melding med ERROR som sier at `System` er forventet i arkivmeldingobjektet
doc.Load(reader);
```
