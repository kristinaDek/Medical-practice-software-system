using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;

namespace SistemskeOperacije.PretraziSO
{
    public class PretraziKartonSO : OpstaSO
    {
        public List<Karton> Kartoni { get; set; }
        public string Kriterijum { get; set; }
        public PretraziKartonSO(string kriterijum)
        {
            Kriterijum = kriterijum;
        }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Kartoni = broker.VratiObjekteKriterijum(Kriterijum, objekat).OfType<Karton>().ToList();
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Karton))
                throw new Exception("Objekat nije karton!");
        }
    }
}
