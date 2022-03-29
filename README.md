# Produserer nuget som inneholder XSD skjema og genererte modeller

## Skript for å generere modeller

`GenerateModels.sh` forventer at XSD-skjemaene er plassert under `/Schema/V1`. Den kopierer kopierer XSD skjema og generere C# klasser i prosjektet `KS.Fiks.Arkiv.Models` som blir pakket til nuget.

Se readme.md i `KS.Fiks.Arkiv.Models.V1` for bruk av nuget.
