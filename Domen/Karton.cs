using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Karton : IOpstiDomenskiObjekat
    {
        private int sifraKartona;
        private String jmbg;
        private String imeIPrezime;       
        private DateTime datumRodjenja;
        private int sifra;

        public Karton(int sifra)
        {
            this.sifra = sifra;
        }
        public Karton()
        {
          
        }

        public int SifraKartona { get => sifraKartona; set => sifraKartona = value; }
        [DisplayName("JMBG")]
        public string Jmbg { get => jmbg; set => jmbg = value; }
        //[Browsable(true)]
        [DisplayName("Ime i prezime")]
        public string ImeIPrezime { get => imeIPrezime; set => imeIPrezime = value; }
        [DisplayName("Datum rođenja")]
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        [Browsable(false)]
        public string Tabela => "Karton";
        [Browsable(false)]
        public string VrednostiZaInsert => $"{sifraKartona}, '{jmbg}', '{imeIPrezime}', '{datumRodjenja}'";
        [Browsable(false)]
        public string VrednostiID => "SifraKartona";
        [Browsable(false)]
        public string PretragaID => $"SifraKartona = {sifraKartona}";
        [Browsable(false)]
        public string Sort => "SUBSTRING(ImeIPrezime,CHARINDEX(' ',ImeIPrezime)+1,LEN(ImeIPrezime))";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Where => $" where SifraKartona = {sifraKartona}";

        [Browsable(false)]
        public string VrednostiZaUpdate => $"JMBG = '{Jmbg}', ImeIPrezime = '{imeIPrezime}', DatumRodjenja ='{datumRodjenja}'";

       

        public override string ToString()
        {
            return imeIPrezime + " - "+jmbg;
        }

        
        public override bool Equals(object obj)
        {           

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Karton k = (Karton)obj;
            if (k.imeIPrezime.Equals(imeIPrezime) && k.jmbg.Equals(jmbg))
                return true;
            return false;
        }

        public bool proveriIsto(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Karton k = (Karton)obj;
            if (k.imeIPrezime.Equals(imeIPrezime) && k.datumRodjenja.Day == datumRodjenja.Day && k.datumRodjenja.Month == datumRodjenja.Month && k.datumRodjenja.Year == datumRodjenja.Year && k.jmbg.Equals(jmbg))
                return true;
            return false;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaKartona = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Karton k = new Karton
                {
                    SifraKartona = reader.GetInt32(0),
                    Jmbg = reader.GetString(1),
                    ImeIPrezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3)
                };
                listaKartona.Add(k);
            }
            return listaKartona;
        }

        public bool Proveri(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Karton k = (Karton)obj;
            if (k.imeIPrezime.Equals(imeIPrezime) && k.datumRodjenja.Date.Day == datumRodjenja.Date.Day && k.datumRodjenja.Date.Month == datumRodjenja.Date.Month && k.datumRodjenja.Date.Year == datumRodjenja.Date.Year && k.jmbg.Equals(jmbg))
                return true;
            return false;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaKartona = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Karton k = new Karton
                {
                    SifraKartona = reader.GetInt32(0),
                    Jmbg = reader.GetString(1),
                    ImeIPrezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3)
                };
                listaKartona.Add(k);
            }
            return listaKartona;
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            
            if (reader.Read())
            {
                Karton k = new Karton
                {
                    SifraKartona = reader.GetInt32(0),
                    Jmbg = reader.GetString(1),
                    ImeIPrezime = reader.GetString(2),
                    DatumRodjenja = reader.GetDateTime(3)
                };
                return k;
            }
            return null;
        }
    }
}
