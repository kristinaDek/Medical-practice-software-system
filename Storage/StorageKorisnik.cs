using Domen;
using System;
using System.Collections.Generic;

namespace Storage
{
    public class StorageKorisnik
    {
        private List<Korisnik> korisnici;

        public StorageKorisnik()
        {
            korisnici = new List<Korisnik>() {
                new Korisnik {
                Ime = "Jasmina",
                Prezime = "Dekic",
                KorisnickoIme= "jaca",
                Lozinka = "jaca123"
                },
                new Korisnik {
                Ime = "Petar",
                Prezime = "Petrovic",
                KorisnickoIme = "doktor1",
                Lozinka = "sifra",
                },
                new Korisnik {
                Ime = "Nikola",
                Prezime = "Nikolic",
                KorisnickoIme = "doktor2",
                Lozinka = "sifra"
                }
            };           
        }

        public List<Korisnik> VratiSve()
        {
            return korisnici;
        }
    }
}
