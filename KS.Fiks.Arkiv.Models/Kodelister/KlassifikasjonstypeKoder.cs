namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class KlassifikasjonstypeKoder
    {
        public static readonly Kode GaardsOgBruksnummer = new Kode("GBN", "Gårds- og bruksnummer");
        public static readonly Kode FunksjonsbasertHierarkisk = new Kode("FH", "Funksjonsbasert, hierarkisk");
        public static readonly Kode EmnebasertHierarkiskArkivnoekkel = new Kode("EH", "Emnebasert, hierarkisk arkivnøkkel");
        public static readonly Kode EmnebasertEttNivaa = new Kode("E1", "Emnebasert, ett nivå");
        public static readonly Kode KKoder = new Kode("KK", "K-koder");
        public static readonly Kode MangefasettertIkkeHierarki = new Kode("MF", "Mangefasettert, ikke hierarki");
        public static readonly Kode Objektbasert = new Kode("UO", "Objektbasert");
        public static readonly Kode Foedselsnummer = new Kode("PNR", "Fødselsnummer");
    }
}