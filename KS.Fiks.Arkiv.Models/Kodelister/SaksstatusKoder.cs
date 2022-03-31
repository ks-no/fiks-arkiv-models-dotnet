namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class SaksstatusKoder
    {
        public static readonly Kode UnderBehandling = new Kode("B", "Under behandling");
        public static readonly Kode Avsluttet = new Kode("A", "Avsluttet");
        public static readonly Kode Utgaar = new Kode("U", "Utgår");
        public static readonly Kode OpprettetAvSaksbehandler = new Kode("R", "Opprettet av saksbehandler");
        public static readonly Kode AvsluttetAvSaksbehandler = new Kode("S", "Avsluttet av saksbehandler");
        public static readonly Kode UnntattProsesstyring = new Kode("P", "Unntatt prosesstyring");
        public static readonly Kode FerdigFraSaksbehandler = new Kode("F", "Ferdig fra saksbehandler");
    }
}