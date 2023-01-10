using System.Collections.Generic;

namespace KS.Fiks.Arkiv.Models.V1.Meldingstyper
{
    public static class FiksArkivMeldingtype
    {
        // Arkivering
        public const string Arkivmelding = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding";
        public const string ArkivmeldingOppdater = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater";
        public const string ArkivmeldingOppdaterMottatt = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater.mottatt";
        public const string ArkivmeldingOppdaterKvittering = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater.kvittering";
        public const string ArkivmeldingMottatt = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.mottatt";
        public const string ArkivmeldingKvittering = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.kvittering";
        
        // Innsyn Hent
        public const string MappeHent = "no.ks.fiks.arkiv.v1.innsyn.mappe.hent";
        public const string MappeHentResultat = "no.ks.fiks.arkiv.v1.innsyn.mappe.hent.resultat";
        public const string RegistreringHent = "no.ks.fiks.arkiv.v1.innsyn.registrering.hent";
        public const string RegistreringHentResultat = "no.ks.fiks.arkiv.v1.innsyn.registrering.hent.resultat";
        public const string DokumentfilHent = "no.ks.fiks.arkiv.v1.innsyn.dokumentfil.hent";
        public const string DokumentfilHentResultat = "no.ks.fiks.arkiv.v1.innsyn.dokumentfil.hent.resultat";
        
        // Innsyn Søk
        public const string Sok = "no.ks.fiks.arkiv.v1.innsyn.sok";
        public const string SokResultatUtvidet = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.utvidet";
        public const string SokResultatMinimum = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.minimum";
        public const string SokResultatNoekler = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.noekler";
        
        // Feilmeldinger
        public const string Ugyldigforespørsel = "no.ks.fiks.arkiv.v1.feilmelding.ugyldigforespoersel";
        public const string Serverfeil = "no.ks.fiks.arkiv.v1.feilmelding.serverfeil";
        public const string Ikkefunnet = "no.ks.fiks.arkiv.v1.feilmelding.ikkefunnet";
          
        public static readonly List<string> ArkiveringTyper = new List<string>()
        {
            Arkivmelding,
            ArkivmeldingOppdater,
            ArkivmeldingOppdaterKvittering,
            ArkivmeldingMottatt,
            ArkivmeldingKvittering
        };

        public static readonly List<string> FeilmeldingTyper = new List<string>()
        {
            Ugyldigforespørsel,
            Serverfeil,
            Ikkefunnet
        };

        public static readonly List<string> InnsynTyper = new List<string>()
        {
            Sok,
            SokResultatUtvidet,
            SokResultatMinimum,
            SokResultatNoekler,
            MappeHent,
            MappeHentResultat,
            RegistreringHent,
            RegistreringHentResultat,
            DokumentfilHent,
            DokumentfilHentResultat
            
        };

        public static bool IsArkiveringType(string meldingstype)
        {
            return ArkiveringTyper.Contains(meldingstype);
        }

        public static bool IsInnsynType(string meldingstype)
        {
            return InnsynTyper.Contains(meldingstype);
        }

        public static bool IsFeilmelding(string meldingstype)
        {
            return FeilmeldingTyper.Contains(meldingstype);
        }

        public static bool IsGyldigProtokollType(string meldingstype)
        {
            return IsArkiveringType(meldingstype) || IsInnsynType(meldingstype) || IsFeilmelding(meldingstype)
        }
    }
}