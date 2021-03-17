using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.IzmeniSO
{
    public class IzmeniPregledSO : OpstaSO
    {
        public Pregled Pregled { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Pregled pregled = (Pregled)objekat;
            broker.IzmeniObjekat(pregled);
            bool tr = true;
            foreach (StavkaPregleda sp in pregled.ListaStavki)
            {
                if (tr)
                {
                    broker.ObrisiObjekat(sp);
                    tr = false;
                }
                sp.RbPregleda = pregled.RbPregleda;
                broker.SacuvajObjekat(sp);
            }
            Pregled = pregled;
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Pregled))
            {
                throw new ArgumentException("Prosledjeni objekat nije pregled!");
            }
        }
    }
}
