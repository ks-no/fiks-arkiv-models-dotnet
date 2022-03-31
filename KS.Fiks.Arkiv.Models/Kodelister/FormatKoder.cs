namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class FormatKoder
    {
        public static readonly Kode RenTekst = new Kode("RA-TEKST", "Ren tekst");
        public static readonly Kode TIFFV6 = new Kode("RA-TIFF6", "TIFF versjon 6");
        public static readonly Kode PDFA = new Kode("RA-PDF", "PDF/A - ISO 19005-1:2005");
        public static readonly Kode XML = new Kode("RA-XML", "XML");
        public static readonly Kode JPEG = new Kode("RA-JPEG", "JPEG");
        public static readonly Kode SOSI = new Kode("RA-SOSI", "SOSI");
        public static readonly Kode MPEG2 = new Kode("RA-MPEG-2", "MPEG-2");
        public static readonly Kode MP3 = new Kode("RA-MP3", "MP3");
    }
}