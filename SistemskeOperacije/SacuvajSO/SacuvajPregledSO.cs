using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.SacuvajSO
{
    public class SacuvajPregledSO:OpstaSO
    {
        public Pregled Pregled { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Pregled pregled = (Pregled)objekat;
            pregled.RbPregleda = broker.VratiNovId(pregled); 
            broker.SacuvajObjekat(pregled);
            
            foreach (StavkaPregleda sp in pregled.ListaStavki)
            {
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
