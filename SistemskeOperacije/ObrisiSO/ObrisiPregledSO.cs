using Domen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemskeOperacije.ObrisiSO
{
    public class ObrisiPregledSO:OpstaSO
    {
        public Pregled Pregled { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Pregled pregled = (Pregled)objekat;
            broker.ObrisiObjekat(pregled);
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
