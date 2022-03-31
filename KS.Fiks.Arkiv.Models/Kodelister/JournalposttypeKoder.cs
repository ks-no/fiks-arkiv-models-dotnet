namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class JournalposttypeKoder
    {
        public static readonly Kode InngaaendeDokument = new Kode("I", "Inngående dokument");
        public static readonly Kode UtgaaendeDokument = new Kode("U", "Utgående dokument");
        public static readonly Kode OrganinterntDokumentForOppfoelging = new Kode("N", "Organinternt dokument for oppfølging");
        public static readonly Kode OrganinterntDokumentUtenOppfoelging = new Kode("X", "Organinternt dokument uten oppfølging");
        public static readonly Kode Saksframlegg = new Kode("S", "Saksframlegg");
    }
}