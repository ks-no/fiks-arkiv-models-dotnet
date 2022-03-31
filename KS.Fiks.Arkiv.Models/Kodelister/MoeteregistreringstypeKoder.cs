namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class MoeteregistreringstypeKoder
    {
        public static readonly Kode Moeteinnkalling = new Kode("MI", "Møteinnkalling");
        public static readonly Kode Saksframlegg = new Kode("SF", "Saksframlegg");
        public static readonly Kode Saksprotokoll = new Kode("SP", "Saksprotokoll");
        public static readonly Kode Moeteprotokoll = new Kode("MP", "Møteprotokoll");
        public static readonly Kode Saksliste = new Kode("SL", "Saksliste");
        public static readonly Kode OffentligSaksliste = new Kode("OL", "Offentlig saksliste");
        public static readonly Kode VedleggTilMoetesak = new Kode("VL", "Vedlegg til møtesak");
    }
}