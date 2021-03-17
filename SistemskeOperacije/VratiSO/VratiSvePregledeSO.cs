using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.VratiSO
{
    public class VratiSvePregledeSO:OpstaSO
    {
        public List<Pregled> Pregledi { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Pregledi = broker.VratiSveObjekte(new Pregled()).OfType<Pregled>().ToList();
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
