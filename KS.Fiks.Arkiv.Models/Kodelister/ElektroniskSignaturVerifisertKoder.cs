namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class ElektroniskSignaturVerifisertKoder
    {
        public static readonly Kode IkkeVerifisert = new Kode("I", "Signatur påført, ikke verifisert");
        public static readonly Kode Verifisert = new Kode("V", "Signatur påført og verifisert");
    }
}