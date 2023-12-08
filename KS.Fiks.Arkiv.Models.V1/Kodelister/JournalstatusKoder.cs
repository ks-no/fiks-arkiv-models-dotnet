namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class JournalstatusKoder
    {
        public static readonly Kode Journalfoert = new Kode("J", "Journalført");
        public static readonly Kode FerdigstiltAvSaksbehandler = new Kode("F", "Ferdigstilt av saksbehandler");
        public static readonly Kode GodkjentAvLeder = new Kode("G", "Godkjent av leder");
        public static readonly Kode Ekspedert = new Kode("E", "Ekspedert");
        public static readonly Kode Arkivert = new Kode("A", "Arkivert");
        public static readonly Kode Utaar = new Kode("U", "Utgår");
        public static readonly Kode MidlertidigRegistrering = new Kode("M", "Midlertidig registrering av innkommende dokument");
        public static readonly Kode SaksbehandlerRegistrertInnkommende = new Kode("S", "Saksbehandler har registrert innkommende dokument");
        public static readonly Kode ReservertDokument = new Kode("R", "ReservertDokument");
    }
}