namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class MoeteregistreringsstatusKoder
    {
        public static readonly Kode FerdigBehandlet = new Kode("BE", "Ferdig behandlet av utvalget");
        public static readonly Kode UtsattTilNyttMoete = new Kode("UT", "Utsatt til nytt møte i samme utvalg");
        public static readonly Kode SendtTilbake = new Kode("TB", "Sendt tilbake til foregående utvalg");
    }
}