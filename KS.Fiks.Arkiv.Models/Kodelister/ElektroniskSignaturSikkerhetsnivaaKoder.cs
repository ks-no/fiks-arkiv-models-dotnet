namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class ElektroniskSignaturSikkerhetsnivaaKoder
    {
        public static readonly Kode SymmetriskKryptert = new Kode("SK", "Symmetrisk kryptert");
        public static readonly Kode PKIVirksomhetssertifikat = new Kode("V", "Sendt med PKI/virksomhetssertifikat");
        public static readonly Kode PKIPersonStandardSertifikat = new Kode("PS", "Sendt med PKI/'person standard'-sertifikat");
        public static readonly Kode PKIPersonHoeySertifikat = new Kode("PH", "Sendt med PKI/'person høy'-sertifikat");
    }
}