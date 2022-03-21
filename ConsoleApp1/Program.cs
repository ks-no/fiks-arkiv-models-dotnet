// See https://aka.ms/new-console-template for more information

using System.Reflection;
using KS.Fiks.IO.Arkiv.Models.Arkivstruktur;

var arkiv = new Arkiv();

var referencesAssemblies = Assembly
    .GetExecutingAssembly()
    .GetReferencedAssemblies();

var modelsAssemblyName = referencesAssemblies
    .Single(x
        => "KS.Fiks.Arkiv.Models".Equals(x.Name));

using var arkivStream = Assembly.Load(modelsAssemblyName)
    .GetManifestResourceStream("KS.Fiks.Arkiv.Models.Schema.arkivmelding.xsd");

using var reader = new StreamReader(arkivStream);

var arkivXsd = reader.ReadToEnd();

Console.WriteLine(arkivXsd);