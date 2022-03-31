namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class TilgangsrestriksjonKoder
    {
        public static readonly Kode BegrensetEtterSikkerhetsinnstruksen = new Kode("B", "Begrenset etter sikkerhetsinnstruksen");
        public static readonly Kode KonfidensieltEtterSikkerhetsinnstruksen = new Kode("B", "Konfidensielt etter sikkerhetsinnstruksen");
        public static readonly Kode HemmeligEtterSikkerhetsinnstruksen = new Kode("H", "Hemmelig etter sikkerhetsinnstruksen");
        public static readonly Kode FortroligEtterBeskyttelsesinnstruksen = new Kode("F", "Fortrolig etter beskyttelsesinnstruksen");
        public static readonly Kode StrengtFortroligEtterBeskyttelsesinnstruksen = new Kode("SF", "Strengt fortrolig etter beskyttelsesinnstruksen");
        public static readonly Kode UnntattEtterOffentlighetsloven5 = new Kode("5", "Unntatt etter offentlighetsloven § 5");
        public static readonly Kode UnntattEtterOffentlighetsloven5a = new Kode("5a", "Unntatt etter offentlighetsloven § 5a");
        public static readonly Kode UnntattEtterOffentlighetsloven6 = new Kode("6", "Unntatt etter offentlighetsloven § 6");
        public static readonly Kode UnntattEtterOffentlighetsloven11 = new Kode("11", "Unntatt etter offentlighetsloven § 11");
        public static readonly Kode MidlertidigSperret = new Kode("XX", "Midlertidig sperret");
        public static readonly Kode Personalsaker = new Kode("P", "Personalsaker");
        public static readonly Kode Klientsaker = new Kode("KL", "Klientsaker");
    }
}