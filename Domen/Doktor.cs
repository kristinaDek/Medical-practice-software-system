using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Doktor:IOpstiDomenskiObjekat
    {
        private int sifraDoktora;
        private String ime;
        private String prezime;
        private String brojLicence;
        private int sifra;

        public Doktor(int sifra)
        {
            this.sifra = sifra;
        }

        public Doktor()
        {
            
        }

        public int SifraDoktora { get => sifraDoktora; set => sifraDoktora = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojLicence { get => brojLicence; set => brojLicence = value; }
        [Browsable(false)]
        public string Tabela => "Doktor";
        [Browsable(false)]
        public string VrednostiZaInsert => $"{SifraDoktora}, '{Ime}', '{Prezime}', '{brojLicence}'";
        [Browsable(false)]
        public string VrednostiID => "SifraDoktora";
        [Browsable(false)]
        public string PretragaID => $"SifraDoktora = {SifraDoktora}";
        [Browsable(false)]
        public string Sort => "Prezime";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Where => $"";
        [Browsable(false)]
        public string VrednostiZaUpdate => "";

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaDoktora = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Doktor d = new Doktor()
                {
                    SifraDoktora = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    BrojLicence = reader.GetString(3)
                };

                listaDoktora.Add(d);
            }
            return listaDoktora;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaDoktora = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Doktor d = new Doktor()
                {
                    SifraDoktora = reader.GetInt32(0),
                    Ime = reader.GetString(1),
                    Prezime = reader.GetString(2),
                    BrojLicence = reader.GetString(3)
                };

                listaDoktora.Add(d);
            }
            return listaDoktora;
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            try
            {               
                if (reader.Read())
                {
                    Doktor d = new Doktor()
                    {
                        SifraDoktora = reader.GetInt32(0),
                        Ime = reader.GetString(1),
                        Prezime = reader.GetString(2),
                        BrojLicence = reader.GetString(3)
                    };
                    return d;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }           
        }
    }
}
