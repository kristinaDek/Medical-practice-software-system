using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.IzmeniSO
{
    public class IzmeniKartonSO:OpstaSO
    {
        public Karton Karton { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Karton karton = (Karton)objekat;
            broker.IzmeniObjekat(karton);
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
