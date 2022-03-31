namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public static class SakspartRolleKoder
    {
        public static readonly Kode Klient = new Kode("K", "Klient");
        public static readonly Kode Paaroerende = new Kode("P", "Pårørende");
        public static readonly Kode Formynder = new Kode("F", "Formynder");
        public static readonly Kode Advokat = new Kode("A", "Advokat");
    }
}