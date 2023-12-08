namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class SkjermingOpphoererAksjonKoder
    {
        public static readonly Kode Avgraderes = new Kode("A", "Avgraderes ved første kjøring av funksjon for avgradering etter at avgraderingstidspunktet er nådd");
        public static readonly Kode Gjennomgaas = new Kode("G", "Gjennomgås for vurdering av avgradering når angitt avgraderingstidspunkt nås");
        public static readonly Kode Sperrefrist = new Kode("S", "Sperrefrist, avgraderes automatisk når avgraderingsdato nås");
        public static readonly Kode AvgraderingUtfoert = new Kode("AU", "Avgradering utført. Dette er den eneste avgraderingskoden som er tillatt etter at tilgangskode er slettet");
        public static readonly Kode UnntattFraAutomatiskAvgradering = new Kode("U", "Unntatt fra automatisk avgradering");
    }
}