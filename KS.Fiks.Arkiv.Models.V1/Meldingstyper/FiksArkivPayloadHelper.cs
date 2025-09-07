using System;
using System.Collections.Generic;

namespace KS.Fiks.Arkiv.Models.V1.Meldingstyper
{
    public class FiksArkivPayloadHelper
    {
        public static HashSet<string> MeldingstyperMedPayload = new HashSet<string>
        {
            FiksArkivMeldingtype.ArkivmeldingOpprett,
            FiksArkivMeldingtype.ArkivmeldingOpprettKvittering,
            FiksArkivMeldingtype.DokumentobjektOpprett,
            FiksArkivMeldingtype.DokumentobjektOpprettKvittering,
            FiksArkivMeldingtype.AvskrivningOpprett,
            FiksArkivMeldingtype.AvskrivningSlett,
            FiksArkivMeldingtype.Sok,
            FiksArkivMeldingtype.SokResultatMinimum,
            FiksArkivMeldingtype.SokResultatNoekler,
            FiksArkivMeldingtype.SokResultatUtvidet,
            FiksArkivMeldingtype.RegistreringHentResultat,
            FiksArkivMeldingtype.RegistreringHent,
            FiksArkivMeldingtype.MappeHentResultat,
            FiksArkivMeldingtype.MappeHent,
            FiksArkivMeldingtype.DokumentfilHentResultat,
            FiksArkivMeldingtype.DokumentfilHent,
            FiksArkivMeldingtype.KodelisteHent,
            FiksArkivMeldingtype.KodelisteHentResultat,
            FiksArkivMeldingtype.Serverfeil,
            FiksArkivMeldingtype.Ugyldigforespørsel
        };
        
         public static string GetPayloadFilnavn(string messageType)
        {
            switch (messageType)
            {
                case FiksArkivMeldingtype.ArkivmeldingOpprett:
                case FiksArkivMeldingtype.ArkivmeldingOppdater:
                    return "arkivmelding.xml";
                case FiksArkivMeldingtype.DokumentfilHent:
                    return "dokumentfil-hent.xml";
                case FiksArkivMeldingtype.MappeHent:
                    return "mappe-hent.xml";
                case FiksArkivMeldingtype.RegistreringHent:
                    return "registrering-hent.xml";
                case FiksArkivMeldingtype.KodelisteHent:
                    return "kodeliste-hent.xml";
                case FiksArkivMeldingtype.ArkivmeldingOpprettKvittering:
                    return "arkivmelding-kvittering.xml";
                case FiksArkivMeldingtype.Sok:
                    return "sok.xml";
                case FiksArkivMeldingtype.SokResultatMinimum:
                case FiksArkivMeldingtype.SokResultatNoekler:
                case FiksArkivMeldingtype.SokResultatUtvidet:
                case FiksArkivMeldingtype.RegistreringHentResultat:
                case FiksArkivMeldingtype.MappeHentResultat:
                case FiksArkivMeldingtype.KodelisteHentResultat:
                    return "resultat.xml";
                case FiksArkivMeldingtype.Serverfeil:
                case FiksArkivMeldingtype.Ugyldigforespørsel:
                case FiksArkivMeldingtype.Ikkefunnet:
                    return "feilmelding.xml";
                case FiksArkivMeldingtype.DokumentobjektOpprett:
                    return "dokumentobjekt-opprett.xml";
                case FiksArkivMeldingtype.DokumentobjektOpprettKvittering:
                    return "dokumentobjekt-kvittering.xml";
                case FiksArkivMeldingtype.AvskrivningOpprett:
                    return "avskrivning-opprett.xml";
                case FiksArkivMeldingtype.AvskrivningSlett:
                    return "avskrivning-slett.xml";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
         
         public static bool HarPayload(string meldingstype)
         {
             return MeldingstyperMedPayload.Contains(meldingstype);
         }
    }
}