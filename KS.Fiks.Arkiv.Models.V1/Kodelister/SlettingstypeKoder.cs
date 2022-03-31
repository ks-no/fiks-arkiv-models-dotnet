namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class SlettingstypeKoder
    {
        public static readonly Kode Produksjonsformat = new Kode("SP", "Sletting av produksjonsformat");
        public static readonly Kode TidligereVersjon = new Kode("SV", "Sletting av tidligere versjon");
        public static readonly Kode VariantMedSladdetInformasjon = new Kode("SS", "Sletting av variant med sladdet informasjon");
        public static readonly Kode HeleInnholdetIArkivdelen = new Kode("SA", "Sletting av hele innholdet i arkivdelen");
    }
}