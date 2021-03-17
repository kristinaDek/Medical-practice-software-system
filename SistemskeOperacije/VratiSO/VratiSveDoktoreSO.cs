using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.VratiSO
{
    public class VratiSveDoktoreSO:OpstaSO
    {
        public List<Doktor> Doktori { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Doktori = broker.VratiSveObjekte(new Doktor()).OfType<Doktor>().ToList();
        }


        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Doktor))
            {
                throw new ArgumentException("Prosledjeni objekat nije doktor!");
            }
        }
    }
}
