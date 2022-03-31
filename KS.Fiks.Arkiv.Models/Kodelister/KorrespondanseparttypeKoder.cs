namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class KorrespondanseparttypeKoder
    {
        public static readonly Kode Avsender = new Kode("EA", "Avsender");
        public static readonly Kode Mottaker = new Kode("EM", "Mottaker");
        public static readonly Kode Kopimottaker = new Kode("EK", "Kopimottaker");
        public static readonly Kode Gruppemottaker = new Kode("GM", "Gruppemottaker");
        public static readonly Kode InternAvsender = new Kode("IA", "Intern avsender");
        public static readonly Kode InternMottaker = new Kode("IM", "Intern mottaker");
        public static readonly Kode InternKopimottaker = new Kode("IK", "Intern kopimottaker");
    }
}