namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class MoetesakstypeKoder
    {
        public static readonly Kode PolitiskSak = new Kode("PS", "Politisk sak");
        public static readonly Kode DelegertMoetesak = new Kode("DS", "Delegert møtesak");
        public static readonly Kode Referatsak = new Kode("RS", "Referatsak");
        public static readonly Kode Forespoersel = new Kode("FO", "Forespørsel (interpellasjon)");
    }
}