using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace Projekat
{
    public class Komunikacija
    {
        private static Komunikacija instance;
        private Komunikacija()
        {

        }

        public static Komunikacija Instance
        {
            get {
                if (instance == null)
                    instance = new Komunikacija();
                return instance;
            }
        }

        private Socket klijentskiSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

      

        public bool PoveziSe()
        {
            try
            {
                if (klijentskiSocket == null || !klijentskiSocket.Connected)
                {
                    klijentskiSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijentskiSocket.Connect("127.0.0.1",9000);
                    stream = new NetworkStream(klijentskiSocket);
                }
                return true;
            }
            catch (SocketException se)
            {                
                Debug.WriteLine(">>>"+se.Message);
                return false;
            }
        }

        
        

        internal Korisnik Prijava(string korIme, string pass)
        {
            Korisnik k = new Korisnik { KorisnickoIme = korIme,
                                        Lozinka = pass};
            Zahtev z = new Zahtev { Operacija = Operacija.Logovanje, Objekat = k };
            formatter.Serialize(stream, z);
            Odgovor o = (Odgovor)formatter.Deserialize(stream);
            if (o.Signal == Signal.Ok)
            {
                return (Korisnik)o.Objekat;
            }
            else
            {
                return null;
            }
        }
     
        internal IList<Pregled> VratiPregledeKriterijum(string k)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.PretraziPreglede, Objekat = k };
            formatter.Serialize(stream, zahtev);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Pregled>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }

        internal List<Karton> VratiSveKartone()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.VratiSveKartone
            };
            formatter.Serialize(stream, z);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Karton>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }

        internal List<Karton> VratiKartoneKriterijum(string k)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.PretraziKartone, Objekat = k };
            formatter.Serialize(stream, zahtev);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Karton>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }

        internal List<Pregled> vratiSvePregledeZaKarton(Karton k)
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.vratiSvePregledeZaKarton,
                    Objekat = k
                };
                formatter.Serialize(stream, z);
                Odgovor odg = (Odgovor)formatter.Deserialize(stream);
                if (odg.Signal == Signal.Ok)
                {
                    return (List<Pregled>)odg.Objekat;
                }
                else
                {
                    throw new Exception(odg.Poruka);
                }
            }
        internal List<Doktor> VratiSveDoktoreSortirano()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.vratiSveDoktore
            };
            formatter.Serialize(stream, z);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Doktor>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }

        internal List<Dijagnoza> VratiSveDijagnoze()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.vratiSveDijagnoze
            };
            formatter.Serialize(stream, z);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Dijagnoza>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }
        internal List<StavkaPregleda> vratiSveStavke(Pregled p)
            {
                Zahtev z = new Zahtev
                {
                    Operacija = Operacija.vratiSveStavkePregleda,
                    Objekat = p
                };
                formatter.Serialize(stream, z);
                Odgovor odg = (Odgovor)formatter.Deserialize(stream);
                if (odg.Signal == Signal.Ok)
                {
                    return (List<StavkaPregleda>)odg.Objekat;
                }
                else
                {
                    throw new Exception(odg.Poruka);
                }
            }
        internal List<Pregled> vratiSvePreglede()
        {
            Zahtev z = new Zahtev
            {
                Operacija = Operacija.vratiSvePreglede
            };
            formatter.Serialize(stream, z);
            Odgovor odg = (Odgovor)formatter.Deserialize(stream);
            if (odg.Signal == Signal.Ok)
            {
                return (List<Pregled>)odg.Objekat;
            }
            else
            {
                throw new Exception(odg.Poruka);
            }
        }


        internal Karton SacuvajKarton(Karton karton)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.SacuvajKarton, Objekat = karton };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Karton)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

        internal Pregled SacuvajPregled(Pregled pregled)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.SacuvajPregled, Objekat = pregled };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Pregled)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

      

        internal Pregled ObrisiPregled(Pregled pregled)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.ObrisiPregled, Objekat = pregled };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Pregled)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

        internal Karton ObrisiKarton(Karton karton)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.ObrisiKarton, Objekat = karton };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Karton)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

        internal Karton IzmeniKarton(Karton karton)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.IzmeniKarton, Objekat = karton };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Karton)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }

        internal Pregled IzmeniPregled(Pregled pregled)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.IzmeniPregled, Objekat = pregled };
            formatter.Serialize(stream, zahtev);
            Odgovor odgovor = (Odgovor)formatter.Deserialize(stream);
            if (odgovor.Signal == Signal.Ok)
            {
                return (Pregled)odgovor.Objekat;
            }
            else
            {
                throw new Exception(odgovor.Poruka);
            }
        }
       
    }
}
