namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class AvskrivingsmaateKoder
    {
        public static readonly Kode BesvartMedBrev = new Kode("BU", "Besvart med brev");
        public static readonly Kode BesvartMedEpost = new Kode("BE", "Besvart med e-post");
        public static readonly Kode BesvartPaaTelefon = new Kode("TLF", "Besvart på telefon");
        public static readonly Kode TattTilEtteretning = new Kode("TE", "Tatt til etteretning");
        public static readonly Kode TattTilOrientering = new Kode("TO", "Tatt til orientering");
    }
}