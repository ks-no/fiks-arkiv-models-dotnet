namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class FlytStatusKoder
    {
        public static readonly Kode Godkjent = new Kode("G", "Godkjent");
        public static readonly Kode IkkeGodkjent = new Kode("I", "Ikke godkjent");
        public static readonly Kode SendtTilbake = new Kode("S", "Sendt tilbake til saksbehandler med kommentarer");
    }
}