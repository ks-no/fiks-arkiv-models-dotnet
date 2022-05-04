using System.Collections.Generic;

namespace KS.Fiks.Arkiv.Models.V1.Meldingstyper
{
    public class FiksArkivV1PayloadHelper
    {
        public static HashSet<string> MeldingstyperMedPayload = new HashSet<string>
        {
            FiksArkivV1Meldingtype.Arkivmelding,
            FiksArkivV1Meldingtype.ArkivmeldingKvittering,
            FiksArkivV1Meldingtype.Sok,
            FiksArkivV1Meldingtype.SokResultatMinimum,
            FiksArkivV1Meldingtype.SokResultatNoekler,
            FiksArkivV1Meldingtype.SokResultatUtvidet,
            FiksArkivV1Meldingtype.JournalpostHentResultat,
            FiksArkivV1Meldingtype.JournalpostHent,
            FiksArkivV1Meldingtype.MappeHentResultat,
            FiksArkivV1Meldingtype.MappeHent,
            FiksArkivV1Meldingtype.DokumentfilHentResultat,
            FiksArkivV1Meldingtype.DokumentfilHent
        };
        
         public static string GetPayloadFilnavn(string messageType)
        {
            switch (messageType)
            {
                case FiksArkivV1Meldingtype.Arkivmelding:
                case FiksArkivV1Meldingtype.DokumentfilHent:
                case FiksArkivV1Meldingtype.MappeHent:
                case FiksArkivV1Meldingtype.JournalpostHent:
                    return "arkivmelding.xml";
                case FiksArkivV1Meldingtype.ArkivmeldingKvittering:
                    return "arkivmelding-kvittering.xml";
                case FiksArkivV1Meldingtype.Sok:
                    return "sok.xml";
                case FiksArkivV1Meldingtype.SokResultatMinimum:
                case FiksArkivV1Meldingtype.SokResultatNoekler:
                case FiksArkivV1Meldingtype.SokResultatUtvidet:
                case FiksArkivV1Meldingtype.JournalpostHentResultat:
                case FiksArkivV1Meldingtype.DokumentfilHentResultat:
                case FiksArkivV1Meldingtype.MappeHentResultat:
                    return "resultat.xml";
                default:
                    return string.Empty;
            }
        }
         
         public static bool HarPayload(string meldingstype)
         {
             return MeldingstyperMedPayload.Contains(meldingstype);
         }
    }
}