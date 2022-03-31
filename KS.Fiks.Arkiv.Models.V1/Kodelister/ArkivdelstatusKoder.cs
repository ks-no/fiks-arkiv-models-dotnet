namespace KS.Fiks.Arkiv.Models.V1.Kodelister
{
    public static class ArkivdelstatusKoder
    {
        public static readonly Kode AktivPeriode = new Kode("A", "Aktiv periode");
        public static readonly Kode Overlappingsperiode = new Kode("O", "Overlappingsperiode");
        public static readonly Kode AvsluttetPeriode = new Kode("P", "Avsluttet periode");
        public static readonly Kode UaktuelleMapper = new Kode("U", "Uaktuelle mapper");
    }
}