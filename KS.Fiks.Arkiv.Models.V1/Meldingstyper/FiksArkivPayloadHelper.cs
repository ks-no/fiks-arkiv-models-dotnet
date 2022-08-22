using System;
using System.Collections.Generic;

namespace KS.Fiks.Arkiv.Models.V1.Meldingstyper
{
    public class FiksArkivPayloadHelper
    {
        public static HashSet<string> MeldingstyperMedPayload = new HashSet<string>
        {
            FiksArkivMeldingtype.Arkivmelding,
            FiksArkivMeldingtype.ArkivmeldingKvittering,
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
            FiksArkivMeldingtype.Serverfeil,
            FiksArkivMeldingtype.Ugyldigforespørsel
        };
        
         public static string GetPayloadFilnavn(string messageType)
        {
            switch (messageType)
            {
                case FiksArkivMeldingtype.Arkivmelding:
                case FiksArkivMeldingtype.DokumentfilHent:
                case FiksArkivMeldingtype.MappeHent:
                case FiksArkivMeldingtype.RegistreringHent:
                    return "arkivmelding.xml";
                case FiksArkivMeldingtype.ArkivmeldingKvittering:
                    return "arkivmelding-kvittering.xml";
                case FiksArkivMeldingtype.Sok:
                    return "sok.xml";
                case FiksArkivMeldingtype.SokResultatMinimum:
                case FiksArkivMeldingtype.SokResultatNoekler:
                case FiksArkivMeldingtype.SokResultatUtvidet:
                case FiksArkivMeldingtype.RegistreringHentResultat:
                case FiksArkivMeldingtype.DokumentfilHentResultat:
                case FiksArkivMeldingtype.MappeHentResultat:
                    return "resultat.xml";
                case FiksArkivMeldingtype.Serverfeil:
                case FiksArkivMeldingtype.Ugyldigforespørsel:
                    return "feilmelding.xml";
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