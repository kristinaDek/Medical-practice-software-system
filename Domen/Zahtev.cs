using System;
using System.Collections.Generic;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }

    public enum Operacija
    {
        Logovanje,
        VratiSveKartone,
        SacuvajKarton,
        SacuvajPregled,
        vratiSveDijagnoze,
        vratiSveDoktore,
        vratiSvePreglede,
        vratiSveStavkePregleda,
        vratiSvePregledeZaKarton,
        ObrisiKarton,
        ObrisiPregled,
        IzmeniKarton,
        IzmeniPregled,
        IzmeniStavku,
        PretraziKartone,
        PretraziPreglede,
    }
}
