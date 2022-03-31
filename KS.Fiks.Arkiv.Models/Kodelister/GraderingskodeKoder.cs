namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class GraderingskoderKoder
    {
        public static readonly Kode StrengtHemmelig = new Kode("SH", "Strengt hemmelig (sikkerhetsgrad)");
        public static readonly Kode Hemmelig = new Kode("H", "Hemmelig (sikkerhetsgrad)");
        public static readonly Kode Konfidensielt = new Kode("K", "Konfidensielt (sikkerhetsgrad)");
        public static readonly Kode Begrenset = new Kode("B", "Begrenset (sikkerhetsgrad)");
        public static readonly Kode Fortrolig = new Kode("F", "Fortrolig (beskyttelsesgrad)");
        public static readonly Kode StrengtFortrolig = new Kode("SF", "Strengt fortrolig (beskyttelsesgrad)");
    }
}