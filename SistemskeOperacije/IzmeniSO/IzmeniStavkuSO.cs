using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.IzmeniSO
{
    public class IzmeniStavkuSO : OpstaSO
    {
        public StavkaPregleda StavkaPregleda { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            StavkaPregleda stavka = (StavkaPregleda)objekat;
            broker.IzmeniObjekat(stavka);
            StavkaPregleda = stavka;
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is StavkaPregleda))
            {
                throw new ArgumentException("Prosledjeni objekat nije stavka pregleda!");
            }
        }
    }
}
