using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.ObrisiSO
{
    public class ObrisiKartonSO:OpstaSO
    {
        public Karton Karton { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Karton karton = (Karton)objekat;
            broker.ObrisiObjekat(karton);
            Karton = karton;
           
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
