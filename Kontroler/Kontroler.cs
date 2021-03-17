using BrokerBazePodataka;
using Domen;
using SistemskeOperacije;
using SistemskeOperacije.IzmeniSO;
using SistemskeOperacije.ObrisiSO;
using SistemskeOperacije.SacuvajSO;
using SistemskeOperacije.VratiSO;
using SistemskeOperacije.PretraziSO;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using SistemskeOperacije.PrijvaSO;

namespace Kontroler
{
    public class Kontroler
    {
        
        private Broker broker = new Broker();

        private Kontroler()
        {
        }

        private static Kontroler _instance;
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Kontroler();
                }
                return _instance;
            }
        }


        public Korisnik Prijava(string korIme, string loz)
        {
            Korisnik k = new Korisnik
            {
                KorisnickoIme = korIme,
                Lozinka = loz
            };
            OpstaSO oso = new PrijavaKorisnikaSO();
            oso.IzvrsiSO(k);
            return ((PrijavaKorisnikaSO)oso).Korisnik;
        }



        public List<Pregled> vratiSvePreglede()
        {
            OpstaSO so = new SistemskeOperacije.VratiSO.VratiSvePregledeSO();
            so.IzvrsiSO(new Pregled());
            List<Pregled> pregledi = ((VratiSvePregledeSO)so).Pregledi;
            foreach (Pregled p in pregledi)
            {
                p.Doktor = vratiDoktora(p.Doktor.SifraDoktora);
                p.Karton = VratiKarton(p.Karton.SifraKartona);
            }
            return pregledi;
        }

       
        public List<Pregled> vratiSvePregledeZaKarton(Karton k)
        {
            List<Pregled> pregledi = new List<Pregled>();
            List<Pregled> lista = vratiSvePreglede();
            foreach (Pregled p in lista)
            {
                if (p.Karton.SifraKartona == k.SifraKartona)
                {
                    pregledi.Add(p);
                }
            }
            return pregledi;
        }
                

        private Karton VratiKarton(int sifra)
        {

            List<Karton> kartoni = VratiSveKartone();
            foreach (Karton dk in kartoni)
            {
                if (dk.SifraKartona == sifra)
                    return dk;
            }
            return new Karton(sifra);
        }

        private Doktor vratiDoktora(int sifra)
        {

            List<Doktor> doktori = VratiSveDoktore();
            foreach (Doktor dk in doktori)
            {
                if (dk.SifraDoktora == sifra)
                    return dk;
            }
            return new Doktor(sifra);
        }

       private Dijagnoza VratiDijagnozu(int sifra)
        {
            List<Dijagnoza> dijagnoze = VratiSveDijagnoze();
            foreach (Dijagnoza dk in dijagnoze)
            {
                if (dk.SifraDijagnoze == sifra)
                    return dk;
            }
            return new Dijagnoza(sifra);
        }

        public List<StavkaPregleda> vratiSveStavke(Pregled p)
        {
            OpstaSO so = new SistemskeOperacije.VratiSO.VratiSveStavkePregleda();
            so.IzvrsiSO(new StavkaPregleda());
            List<StavkaPregleda> stavke = ((VratiSveStavkePregleda)so).Stavke;
            if (stavke.Count != 0)
            {
                List<StavkaPregleda> stavke2 = new List<StavkaPregleda>();
                foreach (StavkaPregleda sp in stavke)
                {
                    if (sp.RbPregleda == p.RbPregleda)
                    {
                        stavke2.Add(sp);
                    }
                }

                stavke = stavke2;
            }
            
            return stavke;
        }
       
        public List<Karton> VratiSveKartone()
        {
            OpstaSO so = new SistemskeOperacije.VratiSO.VratiSveKartoneSO();
            so.IzvrsiSO(new Karton());
            List<Karton> kartoni = ((VratiSveKartoneSO)so).Kartoni;
            return kartoni;
        }

        public List<Doktor> VratiSveDoktore()
        {
            OpstaSO so = new SistemskeOperacije.VratiSO.VratiSveDoktoreSO();
            so.IzvrsiSO(new Doktor());
            return ((VratiSveDoktoreSO)so).Doktori;
        }
     

        public List<Dijagnoza> VratiSveDijagnoze()
        {
            OpstaSO so = new SistemskeOperacije.VratiSO.VratiSveDijagnozeSO();
            so.IzvrsiSO(new Dijagnoza());
            return ((VratiSveDijagnozeSO)so).Dijagnoze;
        }

       
        public Karton SacuvajKarton(Karton k)
        {
            OpstaSO so = new SacuvajKartonSO();
            so.IzvrsiSO(k);
            return ((SacuvajKartonSO)so).Karton;
        }

        public Pregled SacuvajPregled(Pregled pr)
        {
            OpstaSO so = new SacuvajPregledSO();
            so.IzvrsiSO(pr);
            return ((SacuvajPregledSO)so).Pregled;
        }

      
        public Karton IzmeniKarton(Karton k)
        {
            OpstaSO oso = new IzmeniKartonSO();
            oso.IzvrsiSO(k);
            return ((IzmeniKartonSO)oso).Karton;
        }

        public Pregled IzmeniPregled(Pregled p)
        {
            OpstaSO oso = new IzmeniPregledSO();
            oso.IzvrsiSO(p);
            return ((IzmeniPregledSO)oso).Pregled;
        }
        public StavkaPregleda IzmeniStavku(StavkaPregleda sp)
        {
            OpstaSO oso = new IzmeniStavkuSO();
            oso.IzvrsiSO(sp);
            return ((IzmeniStavkuSO)oso).StavkaPregleda;
        }

        public List<Karton> VratiKartonKriterijum(string v)
        {            
            OpstaSO oso = new PretraziKartonSO(v);
            oso.IzvrsiSO(new Karton());
            return ((PretraziKartonSO)oso).Kartoni;
        }

        public Karton ObrisiKarton(Karton k)
        {
            OpstaSO so = new ObrisiKartonSO();
            so.IzvrsiSO(k);
            return ((ObrisiKartonSO)so).Karton;
        }

        public List<Pregled> VratiPregledeKriterijum(string v)
        {
            OpstaSO oso = new PretraziPregledeSO(v);
            oso.IzvrsiSO(new Pregled());
            return ((PretraziPregledeSO)oso).Pregledi;
        }

        public Pregled ObrisiPregled(Pregled p)
        {
            OpstaSO so = new ObrisiPregledSO();
            so.IzvrsiSO(p);
            return ((ObrisiPregledSO)so).Pregled;
        }

    }
}
