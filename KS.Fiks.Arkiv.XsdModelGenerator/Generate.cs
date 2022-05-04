﻿using System;
using System.IO;
using System.Linq;
using XmlSchemaClassGenerator;

const string commonNamespace = "KS.Fiks.Arkiv.Models.V1";

var generator = new Generator
{
    OutputFolder = args[1],
    Log = s => Console.Out.WriteLine(s),
    GenerateNullables = false,
    SeparateClasses = true,
    NamespaceProvider = new NamespaceProvider
    {
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/metadatakatalog/v2"),
            commonNamespace + ".Metadatakatalog"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmelding/v2"),
            commonNamespace + ".Arkivering.Arkivmelding"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmeldingkvittering/v2"),
            commonNamespace + ".Arkivering.Arkivmeldingkvittering"
        },
        {new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/sok/v1"), commonNamespace + ".Innsyn.Sok"},
        {new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/sokeresultat/v1"), commonNamespace + ".Innsyn.Sok"},
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/arkivstruktur/minimum/v1"),
            commonNamespace + ".Arkivstruktur"
        },
        {
            new NamespaceKey("http://www.ks.no/standarder/fiks/arkiv/arkivstruktur/noekler/v1"),
            commonNamespace + ".Arkivstruktur"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivstruktur"),
            commonNamespace + ".Arkivstruktur"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/dokumentfil/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Dokumentfil"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/journalpost/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Journalpost"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/journalpost/hent/resultat/v2"),
            commonNamespace + ".Innsyn.Hent.Journalpost"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/mappe/hent/v2"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/mappe/hent/resultat/v2"),
            commonNamespace + ".Innsyn.Hent.Mappe"
        },
        {
            new NamespaceKey("http://www.arkivverket.no/standarder/noark5/arkivmeldingoppdatering/v2"),
            commonNamespace + ".Arkivering.Arkivmelding.Oppdatering"
        }
    }
};
var schemaFolder = new DirectoryInfo(args[0]);
var schemasToGenerate = schemaFolder
    .GetFiles()
    .Where(file => file.Extension.Equals(".xsd"))
    .Select(file => Path.Combine(args[0], file.Name));

generator.Generate(schemasToGenerate);