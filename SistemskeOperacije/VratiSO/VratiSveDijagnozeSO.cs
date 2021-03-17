using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.VratiSO
{
    public class VratiSveDijagnozeSO:OpstaSO
    {
        public List<Dijagnoza> Dijagnoze { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Dijagnoze = broker.VratiSveObjekte(new Dijagnoza()).OfType<Dijagnoza>().ToList();
        }


        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Dijagnoza))
            {
                throw new ArgumentException("Prosledjeni objekat nije dijagnoza!");
            }
        }
    }
}
