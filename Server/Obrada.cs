using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Obrada
    {
        private Socket klijentskiSocket;
        private Server server;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public Obrada(Socket klijentskiSocket, Server server)
        {
            this.klijentskiSocket = klijentskiSocket;
            this.server = server;
            this.stream = new NetworkStream(klijentskiSocket);
        }

        public void ObradaZahteva()
        {           
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev = (Zahtev)formatter.Deserialize(stream);
                    Odgovor odgovor = KreirajOdgovor(zahtev);
                    formatter.Serialize(stream,odgovor);
                }
                catch (IOException io)
                {
                    Debug.WriteLine(">>>" + io.Message);
                    kraj = true;
                }            
            }
           
        }

        private Odgovor KreirajOdgovor(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor();
            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.Logovanje:
                        Korisnik k = (Korisnik)zahtev.Objekat;     
                        Korisnik pronadjeniKorisnik = Kontroler.Kontroler.Instance.Prijava(k.KorisnickoIme, k.Lozinka);
                        odgovor.Poruka = "Sistem je uspesno pronasao korisnika!";
                        odgovor.Objekat = pronadjeniKorisnik;
                        server.Zaposleni.Add(pronadjeniKorisnik);
                        break;
                    case Operacija.VratiSveKartone:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveKartone();
                        odgovor.Poruka = "Uspesno vraceni svi kartoni.";
                        break;
                    case Operacija.SacuvajKarton:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajKarton((Karton)zahtev.Objekat);
                        odgovor.Poruka = "Uspesno sacuvan karton!";
                        break;
                    case Operacija.SacuvajPregled:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajPregled((Pregled)zahtev.Objekat);
                        odgovor.Poruka = "Uspesno sacuvan pregled!";
                        break;
                    case Operacija.vratiSveDijagnoze:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveDijagnoze();
                        odgovor.Poruka = "Uspesno vracene sve dijagnoze!";
                        break;
                    case Operacija.vratiSveDoktore:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiSveDoktore();
                        odgovor.Poruka = "Uspesno vraceni svi doktori!";
                        break;
                    case Operacija.vratiSvePreglede:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.vratiSvePreglede();
                        odgovor.Poruka = "Uspesno vraceni svi pregledi!";
                        break;
                    case Operacija.vratiSveStavkePregleda:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.vratiSveStavke((Pregled)zahtev.Objekat);
                        odgovor.Poruka = "Uspesno vracene sve stavke pregleda!";
                        break;
                    case Operacija.vratiSvePregledeZaKarton:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.vratiSvePregledeZaKarton((Karton)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno vraceni svi pregledi za zadati karton pacijenta {((Karton)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.ObrisiKarton:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.ObrisiKarton((Karton)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno obrisan karton pacijenta {((Karton)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.ObrisiPregled:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.ObrisiPregled((Pregled)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno obrisan pregled pacijenta {((Pregled)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.IzmeniKarton:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.IzmeniKarton((Karton)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno izmenjen karton pacijenta {((Karton)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.IzmeniPregled:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.IzmeniPregled((Pregled)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno izmenjen pregled pacijenta {((Pregled)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.IzmeniStavku:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.IzmeniStavku((StavkaPregleda)zahtev.Objekat);
                        odgovor.Poruka = $"Uspesno izmenjena stavka pregleda pacijenta {((StavkaPregleda)zahtev.Objekat).ToString()}!";
                        break;
                    case Operacija.PretraziKartone:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiKartonKriterijum(zahtev.Objekat.ToString());
                        odgovor.Poruka = "Sistem je uspesno pretrazio kartone po kriterijumu!";
                        break;
                    case Operacija.PretraziPreglede:
                        odgovor.Objekat = Kontroler.Kontroler.Instance.VratiPregledeKriterijum(zahtev.Objekat.ToString());
                        odgovor.Poruka = "Sistem je uspesno pretrazio preglede po kriterijumu!";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = e.Message;
            }

            return odgovor;
        }

        //internal void Zaustavi()
        //{
        //    klijentskiSocket.Close();
        //}
    }
}
