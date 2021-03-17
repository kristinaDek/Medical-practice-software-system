using System;
using System.Collections.Generic;
using System.Text;
using Domen;

namespace SistemskeOperacije.PrijvaSO
{
    public class PrijavaKorisnikaSO : OpstaSO
    {
        public Korisnik Korisnik { get; set; }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Korisnik = broker.VratiObjekat(objekat) as Korisnik;            
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Korisnik))
                throw new Exception("Objekat nije korisnik!");
        }
    }
}
