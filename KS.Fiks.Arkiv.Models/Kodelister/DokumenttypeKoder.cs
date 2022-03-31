namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class DokumenttypeKoder
    {
        public static readonly Kode Soeknad = new Kode("SØKNAD", "Søknad");
        public static readonly Kode Melding = new Kode("MELDING", "Melding");
        public static readonly Kode Korrespondanse = new Kode("KORR", "Korrespondanse");
        public static readonly Kode Kart = new Kode("KART", "Kart");
        public static readonly Kode Foto = new Kode("FOTO", "Foto");
        public static readonly Kode Tegning = new Kode("TEGNING", "Tegning");
        public static readonly Kode AnsvarOgKontroll = new Kode("ANSVKONTO", "Ansvar og kontroll");
        public static readonly Kode Tilsyn = new Kode("TILSYN", "Tilsyn");
        public static readonly Kode Avtale = new Kode("AVTALE", "Avtale");
        public static readonly Kode Vedtak = new Kode("VEDTAK", "Vedtak");
        public static readonly Kode FERDIGATTEST = new Kode("FERDIGATTEST", "Ferdigattest");
    }
}