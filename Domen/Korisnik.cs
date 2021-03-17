using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domen
{
    [Serializable]
    public class Korisnik:IOpstiDomenskiObjekat
    {
        private String ime;
        private String prezime;
        private String korisnickoIme;
        private String lozinka;
        private Doktor doktor;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public Doktor Doktor { get => doktor; set => doktor = value; }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaKorisnika = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Korisnik k = new Korisnik();
                k.Ime = reader.GetString(0);
                k.Prezime = reader.GetString(1);
                k.KorisnickoIme = reader.GetString(2);
                k.Lozinka = reader.GetString(3);
                k.Doktor = new Doktor();
                k.Doktor.SifraDoktora = reader.GetInt32(4);
                listaKorisnika.Add(k);
            }
            return listaKorisnika;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {            
            if (reader.Read())
            {
                Korisnik k = new Korisnik();
                k.Ime = reader.GetString(0);
                k.Prezime = reader.GetString(1);
                k.KorisnickoIme = reader.GetString(2);
                k.Lozinka = reader.GetString(3);
                k.Doktor = new Doktor();
                k.Doktor.SifraDoktora = reader.GetInt32(4);
                return k;
            }
            return null;
        }

        [Browsable(false)]
        public string PretragaID => $"KorisnickoIme = '"+KorisnickoIme+"' and Lozinka = '"+Lozinka+"' ";

        

        public string Tabela => "Korisnik";

        public string VrednostiZaInsert => throw new NotImplementedException();

        public string VrednostiID => throw new NotImplementedException();

        public string Sort => throw new NotImplementedException();

        public string Join => throw new NotImplementedException();

        public string Where => throw new NotImplementedException();

        public string VrednostiZaUpdate => throw new NotImplementedException();
    }
}
