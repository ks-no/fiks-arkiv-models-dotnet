using System.Collections.Generic;

namespace KS.Fiks.Arkiv.Models.V1.Meldingstyper
{
    public static class FiksArkivMeldingtype
    {
        // Arkivering
        public const string ArkivmeldingOpprett = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.opprett";
        public const string ArkivmeldingOppdater = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater";
        public const string ArkivmeldingOppdaterMottatt = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater.mottatt";
        public const string ArkivmeldingOppdaterKvittering = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.oppdater.kvittering";
        public const string ArkivmeldingOpprettMottatt = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.opprett.mottatt";
        public const string ArkivmeldingOpprettKvittering = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.opprett.kvittering";
        public const string DokumentobjektOpprett = "no.ks.fiks.arkiv.v1.arkivering.dokumentobjekt.opprett";
        public const string DokumentobjektOpprettMottatt = "no.ks.fiks.arkiv.v1.arkivering.dokumentobjekt.opprett.mottatt";
        public const string DokumentobjektOpprettKvittering = "no.ks.fiks.arkiv.v1.arkivering.dokumentobjekt.opprett.kvittering";
        public const string AvskrivningOpprett = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.opprett";
        public const string AvskrivningOpprettMottatt = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.opprett.mottatt";
        public const string AvskrivningOpprettKvittering = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.opprett.kvittering";
        public const string AvskrivningSlett = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.slett";
        public const string AvskrivningSlettMottatt = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.slett.mottatt";
        public const string AvskrivningSlettKvittering = "no.ks.fiks.arkiv.v1.arkivering.avskrivning.slett.kvittering";
        
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
            ArkivmeldingOpprett,
            ArkivmeldingOpprettMottatt,
            ArkivmeldingOpprettKvittering,
            ArkivmeldingOppdater,
            ArkivmeldingOppdaterMottatt,
            ArkivmeldingOppdaterKvittering,
            DokumentobjektOpprett,
            DokumentobjektOpprettMottatt,
            DokumentobjektOpprettKvittering,
            AvskrivningOpprett,
            AvskrivningOpprettMottatt,
            AvskrivningOpprettKvittering,
            AvskrivningSlett,
            AvskrivningSlettMottatt,
            AvskrivningSlettKvittering
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
            return IsArkiveringType(meldingstype) || IsInnsynType(meldingstype) || IsFeilmelding(meldingstype);
        }
    }
}