using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.Edunova
{
    internal class Smjer
    {
        public int? Sifra { get; set; }
        public string? Naziv { get; set; }
        public int? Trajanje { get; set; }
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool Verificiran { get; set; }




        private int broj;

        public int getBroj()
        {
            return broj;
        }
        public void setBroj(int broj)
        {
            this.broj = broj;
        }
    }
}
