namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class DokumentstatusKoder
    {
        public static readonly Kode UnderRedigering = new Kode("B", "Dokumentet er under redigering");
        public static readonly Kode Ferdig = new Kode("F", "Dokumentet er ferdigstilt");
    }
}