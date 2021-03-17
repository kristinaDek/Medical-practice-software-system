using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.SacuvajSO
{
    public class SacuvajKartonSO : OpstaSO
    {
        public Karton Karton { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Karton k = (Karton)objekat;
            k.SifraKartona = broker.VratiNovId(k);
            
            if (!broker.SacuvajObjekat(k))
                throw new Exception("Nije moguće kreirati karton.");
            Karton = k;
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Karton))
            {
                throw new ArgumentException("Prosledjeni objekat nije karton!");
            }
        }
    }
}
