using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Pregled : IOpstiDomenskiObjekat
    {
        private int rbPregleda;
        private String nalaz;
        private DateTime datumPregleda;
        private bool kontrola;
        private bool prviPregled;       
        private String napomena;
        private Karton karton;
        private string pacijent;
        private Doktor doktor;
        private List<StavkaPregleda> listaStavki;

        public int RbPregleda { get => rbPregleda; set => rbPregleda = value; }
        public string Nalaz { get => nalaz; set => nalaz = value; }
        public DateTime DatumPregleda { get => datumPregleda; set => datumPregleda = value; }
        public bool Kontrola { get => kontrola; set => kontrola = value; }
        public bool PrviPregled { get => prviPregled; set => prviPregled = value; }       
        public string Napomena { get => napomena; set => napomena = value; }
        [Browsable(false)]
        public Karton Karton { get => karton; set => karton = value; }
        public Doktor Doktor { get => doktor; set => doktor = value; }
       
        public string Pacijent { get
            {
                return karton.ImeIPrezime;
            } }
        public List<StavkaPregleda> ListaStavki { get => listaStavki; set => listaStavki = value; }
        [Browsable(false)]
        public string Tabela => "Pregled";
        [Browsable(false)]
        public string VrednostiZaInsert => $"{RbPregleda}, '{Nalaz}', '{DatumPregleda}', {Convert.ToInt32(Kontrola)}, {Convert.ToInt32(PrviPregled)}, '{Napomena}', {Karton.SifraKartona}, {Doktor.SifraDoktora}";
        [Browsable(false)]
        public string VrednostiID => "RBPregleda";
        [Browsable(false)]
        public string PretragaID => $"RBPregleda = {RbPregleda} and SifraKartona = {Karton.SifraKartona}";
        [Browsable(false)]
        public string Sort => "pr.DatumPregleda desc";
        [Browsable(false)]
        public string Join => "as pr inner join Karton k on (pr.SifraKartona = k.SifraKartona) inner join Doktor d on (pr.SifraDoktora = d.SifraDoktora) ";
        [Browsable(false)]
        public string Where => $" where RBPregleda = {RbPregleda}";
        [Browsable(false)]
        public string VrednostiZaUpdate => $"Nalaz = '{Nalaz}', DatumPregleda = '{DatumPregleda}' , Kontrola = {Convert.ToInt32(Kontrola)}, PrviPregled = {Convert.ToInt32(PrviPregled)} , Napomena = '{Napomena}' , SifraKartona = {Karton.SifraKartona} , SifraDoktora = {Doktor.SifraDoktora}";

        public Pregled()
        {
            datumPregleda = DateTime.Now.Date;
            ListaStavki = new List<StavkaPregleda>();
            Karton = new Karton();
            Doktor = new Doktor();
        }

        public override string ToString()
        {
            return Karton.ImeIPrezime;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Pregled k = (Pregled)obj;
            if (k.RbPregleda == RbPregleda && k.Nalaz.Equals(Nalaz) && k.datumPregleda.Date.Day == DatumPregleda.Date.Day && k.datumPregleda.Date.Month == DatumPregleda.Date.Month && k.datumPregleda.Date.Year == DatumPregleda.Date.Year &&
                k.kontrola == Kontrola && k.prviPregled == PrviPregled && k.napomena.Equals(Napomena) && k.Karton.SifraKartona == Karton.SifraKartona && k.Doktor.SifraDoktora == Doktor.SifraDoktora)
                return true;

            return false;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaPregleda = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Pregled pr = new Pregled();

                pr.RbPregleda = reader.GetInt32(0);
                pr.Nalaz = reader.GetString(1);
                pr.DatumPregleda = reader.GetDateTime(2);
                pr.Kontrola = reader.GetBoolean(3);
                pr.PrviPregled = reader.GetBoolean(4);
                pr.Napomena = reader.GetString(5);
                pr.Karton = new Karton
                {
                    SifraKartona = reader.GetInt32(6)
                };
                pr.Doktor = new Doktor
                {
                    SifraDoktora = reader.GetInt32(7)
                };


                listaPregleda.Add(pr);
            }
            return listaPregleda;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaPregleda = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Pregled pr = new Pregled();

                pr.RbPregleda = reader.GetInt32(0);
                pr.Nalaz = reader.GetString(1);
                pr.DatumPregleda = reader.GetDateTime(2);
                pr.Kontrola = reader.GetBoolean(3);
                pr.PrviPregled = reader.GetBoolean(4);
                pr.Napomena = reader.GetString(5);
                pr.Karton = new Karton
                {
                    SifraKartona = reader.GetInt32(6),
                    Jmbg = reader.GetString(9),
                    ImeIPrezime = reader.GetString(10),
                    DatumRodjenja = reader.GetDateTime(11),
                };
                pr.Doktor = new Doktor
                {
                    SifraDoktora = reader.GetInt32(7),
                    Ime = reader.GetString(13),
                    Prezime = reader.GetString(14),
                    BrojLicence = reader.GetString(15),
                };


                listaPregleda.Add(pr);
            }
            return listaPregleda;
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            
            if (reader.Read())
            {
                Pregled pr = new Pregled();

                pr.RbPregleda = reader.GetInt32(0);
                pr.Nalaz = reader.GetString(1);
                pr.DatumPregleda = reader.GetDateTime(2);
                pr.Kontrola = reader.GetBoolean(3);
                pr.PrviPregled = reader.GetBoolean(4);
                pr.Napomena = reader.GetString(5);
                pr.Karton = new Karton
                {
                    SifraKartona = reader.GetInt32(6),
                    Jmbg = reader.GetString(9),
                    ImeIPrezime = reader.GetString(10),
                    DatumRodjenja = reader.GetDateTime(11),
                };
                pr.Doktor = new Doktor
                {
                    SifraDoktora = reader.GetInt32(7),
                    Ime = reader.GetString(13),
                    Prezime = reader.GetString(14),
                    BrojLicence = reader.GetString(15),
                };


                return pr;
            }
            return null;
        }
    }
}
