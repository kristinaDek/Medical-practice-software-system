using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;

namespace SistemskeOperacije.VratiSO
{
    public class VratiSveKartoneSO : OpstaSO
    {
        public List<Karton> Kartoni { get; set; }
      
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Kartoni = broker.VratiSveObjekte(new Karton()).OfType<Karton>().ToList();
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
