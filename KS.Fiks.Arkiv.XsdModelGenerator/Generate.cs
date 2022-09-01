using System;
using System.IO;
using System.Linq;
using XmlSchemaClassGenerator;

const string commonNamespace = "KS.Fiks.Arkiv.Models.V1";

var generator = new Generator
{
    OutputFolder = args[1],
    Log = s => Console.Out.WriteLine(s),
    GenerateNullables = true,
    SeparateClasses = true,
    NamespaceProvider = new NamespaceProvider
    {
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2"),
            commonNamespace + ".Metadatakatalog"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/metadatakatalog/v1"),
            commonNamespace + ".Metadatakatalog"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmelding/v2"),
            commonNamespace + ".Arkivering.Arkivmelding"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmelding/v1"),
            commonNamespace + ".Arkivering.Arkivmelding"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmeldingkvittering/v2"),
            commonNamespace + ".Arkivering.Arkivmeldingkvittering"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingkvittering/v1"),
            commonNamespace + ".Arkivering.Arkivmeldingkvittering"
        },
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/sok/v1"), 
            commonNamespace + ".Innsyn.Sok"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sok/v1"), 
            commonNamespace + ".Innsyn.Sok"
        },
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/sokeresultat/v1"), 
            commonNamespace + ".Innsyn.Sok"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/sokeresultat/v1"), 
            commonNamespace + ".Innsyn.Sok"
        },
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/arkivstruktur/minimum/v1"),
            commonNamespace + ".Arkivstruktur.Minimum"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/minimum/v1"),
            commonNamespace + ".Arkivstruktur.Minimum"
        },
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/arkivstruktur/noekler/v1"),
            commonNamespace + ".Arkivstruktur.Noekler"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/noekler/v1"),
            commonNamespace + ".Arkivstruktur.Noekler"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivstruktur"),
            commonNamespace + ".Arkivstruktur"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivstruktur/v1"),
            commonNamespace + ".Arkivstruktur"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/dokumentfil/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Dokumentfil"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/dokumentfil/hent/v1"),
            commonNamespace + ".Innsyn.Hent.Dokumentfil"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/registrering/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Registrering"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/registrering/hent/v1"),
            commonNamespace + ".Innsyn.Hent.Registrering"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/registrering/hent/resultat/v2"),
            commonNamespace + ".Innsyn.Hent.Registrering"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/registrering/hent/resultat/v1"),
            commonNamespace + ".Innsyn.Hent.Registrering"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/mappe/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/mappe/hent/v1"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/mappe/hent/resultat/v2"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/mappe/hent/resultat/v1"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmeldingoppdatering/v2"),
            commonNamespace + ".Arkivering.Arkivmelding.Oppdatering"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/arkivmeldingoppdatering/v1"),
            commonNamespace + ".Arkivering.Arkivmelding.Oppdatering"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/feil/feilmelding/v2"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/feil/feilmelding/v1"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/feil/serverfeil/v2"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/feil/serverfeil/v1"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/feil/ikkefunnet/v2"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/feil/ikkefunnet/v1"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/feil/ugyldigforespoersel/v2"),
            commonNamespace + ".Feilmelding"
        },
        {
            new NamespaceKey("https://ks-no.github.io/standarder/fiks-protokoll/fiks-arkiv/feil/ugyldigforespoersel/v1"),
            commonNamespace + ".Feilmelding"
        }
    }
};
var schemaFolder = new DirectoryInfo(args[0]);
var schemasToGenerate = schemaFolder
    .GetFiles()
    .Where(file => file.Extension.Equals(".xsd"))
    .Select(file => Path.Combine(args[0], file.Name));

generator.Generate(schemasToGenerate);