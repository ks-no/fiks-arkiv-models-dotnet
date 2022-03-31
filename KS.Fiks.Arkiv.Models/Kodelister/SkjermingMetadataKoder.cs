namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class SkjermingMetadataKoder
    {
        public static readonly Kode KlasseID = new Kode("KID", "Skjerming klasseID");
        public static readonly Kode TittelKlasse = new Kode("TKL", "Skjerming tittel klasse");
        public static readonly Kode TittelMappeUnntattFoersteLinje = new Kode("TM1", "Skjerming tittel mappe - unntatt første linje");
        public static readonly Kode TittelMappeUtvalgteOrd = new Kode("TMO", "Skjerming tittel mappe - utvalgte ord");
        public static readonly Kode NavnPartISak = new Kode("NPS", "Skjerming part i sak");
        public static readonly Kode TittelRegistreringUnntattFoersteLinje = new Kode("TR1", "Skjerming tittel registrering - unntatt første linje");
        public static readonly Kode TittelRegistreringUtvalgteOrd = new Kode("TRO", "Skjerming tittel registrering - utvalgte ord");
        public static readonly Kode NavnAvsender = new Kode("NA", "Skjerming navn avsender");
        public static readonly Kode NavnMottaker = new Kode("NM", "Skjerming navn mottaker");
        public static readonly Kode TittelDokumentbeskrivelse = new Kode("TD", "Skjerming tittel dokumentbeskrivelse");
        public static readonly Kode Merknadstekst = new Kode("MT", "Skjerming merknadstekst");
        public static readonly Kode Midlertidig = new Kode("M", "Midlertidig skjerming");
    }
}