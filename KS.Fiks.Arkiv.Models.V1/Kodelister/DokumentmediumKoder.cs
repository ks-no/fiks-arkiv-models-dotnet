namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class DokumentmediumKoder
    {
        public static readonly Kode FysiskMedium = new Kode("F", "Fysisk medium");
        public static readonly Kode ElektroniskArkiv = new Kode("E", "Elektronisk arkiv");
        public static readonly Kode Blandet = new Kode("B", "Blandet fysisk og elektronisk arkiv");
    }
}