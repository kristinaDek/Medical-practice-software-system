using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.VratiSO
{
    public class VratiSveStavkePregleda:OpstaSO
    {

        public List<StavkaPregleda> Stavke { get; set; }

        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Stavke = broker.VratiSveObjekte(new StavkaPregleda()).OfType<StavkaPregleda>().ToList();
          
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
