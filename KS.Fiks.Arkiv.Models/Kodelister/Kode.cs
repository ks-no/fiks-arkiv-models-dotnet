using System;

namespace KS.Fiks.Arkiv.Models.Kodelister
{
    public class Kode
    {
        public string Verdi { get; }
        public string Beskrivelse { get; }

        public Kode(string Verdi, string Beskrivelse)
        {
            if (string.IsNullOrWhiteSpace(Verdi))
            {
                throw new ArgumentException("Kode må ha en verdi");
            }
            this.Verdi = Verdi;
            this.Beskrivelse = Beskrivelse;
        }
    }
}