using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemskeOperacije.PretraziSO
{
    public class PretraziPregledeSO : OpstaSO
    {
        public List<Pregled> Pregledi { get; set; }
        public string Kriterijum { get; set; }
        public PretraziPregledeSO(string kriterijum)
        {
            Kriterijum = kriterijum;
        }
        protected override void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat)
        {
            Pregledi = broker.VratiObjekteKriterijum(Kriterijum, objekat).OfType<Pregled>().ToList();
        }

        protected override void Validacija(IOpstiDomenskiObjekat objekat)
        {
            if (!(objekat is Pregled))
                throw new Exception("Objekat nije pregled!");
        }
    }
}
