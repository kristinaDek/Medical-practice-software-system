using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    [Serializable]
    public class StavkaPregleda : IOpstiDomenskiObjekat
    {
        private int rbPregleda;
        private int rbStavke;
        private String nalaz;
        private String napomena;
        private Dijagnoza dijagnoza;

        public int RbStavke { get => rbStavke; set => rbStavke = value; }
        public string Nalaz { get => nalaz; set => nalaz = value; }
        public string Napomena { get => napomena; set => napomena = value; }
        public Dijagnoza Dijagnoza { get => dijagnoza; set => dijagnoza = value; }
        [Browsable(false)]
        public string Tabela => "StavkaPregleda";
        [Browsable(false)]
        public string VrednostiZaInsert => $"{RbPregleda}, {RbStavke}, '{Nalaz}', '{Napomena}', {Dijagnoza.SifraDijagnoze}";
        [Browsable(false)]
        public string VrednostiID => "RBStavke";
        [Browsable(false)]
        public string PretragaID => $"RBPregleda = {RbPregleda}";
        [Browsable(false)]
        public string Sort => "sp.RBStavke asc";
        [Browsable(false)]
        public string Join => " sp join Dijagnoza d on (sp.SifraDijagnoze = d.SifraDijagnoze)";
        [Browsable(false)]
        public int RbPregleda { get => rbPregleda; set => rbPregleda = value; }
        [Browsable(false)]
        public string Where => $" where RBPregleda = {RbPregleda} and RBStavke = {RbStavke}";
        [Browsable(false)]
        public string VrednostiZaUpdate => $"Nalaz = '%{Nalaz}%' , Napomena = '%{Napomena}%' , SifraDijagnoze = {Dijagnoza.SifraDijagnoze}";

        

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            StavkaPregleda k = (StavkaPregleda)obj;
            if (k.rbStavke == rbStavke && k.nalaz.Equals(nalaz) && k.napomena == napomena && k.dijagnoza == dijagnoza)
                return true;
            return false;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaStavki = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                StavkaPregleda sk = new StavkaPregleda()
                {
                    RbPregleda = reader.GetInt32(0),
                    RbStavke = reader.GetInt32(1),
                    Nalaz = reader.GetString(2),
                    Napomena = reader.GetString(3),
                    Dijagnoza = new Dijagnoza()
                    {
                        SifraDijagnoze = reader.GetInt32(5),
                        NazivDijagnoze = reader.GetString(6),
                    }
            };

                listaStavki.Add(sk);
            }
            return listaStavki;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> listaStavki = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                StavkaPregleda sk = new StavkaPregleda()
                {
                    RbPregleda = reader.GetInt32(0),
                    RbStavke = reader.GetInt32(1),
                    Nalaz = reader.GetString(2),
                    Napomena = reader.GetString(3),
                    Dijagnoza = new Dijagnoza()
                    {
                        SifraDijagnoze = reader.GetInt32(5),
                        NazivDijagnoze = reader.GetString(6),
                    }
                };

                listaStavki.Add(sk);
            }
            return listaStavki;
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
          
            if (reader.Read())
            {
                StavkaPregleda sk = new StavkaPregleda()
                {
                    RbPregleda = reader.GetInt32(0),
                    RbStavke = reader.GetInt32(1),
                    Nalaz = reader.GetString(2),
                    Napomena = reader.GetString(3),
                    Dijagnoza = new Dijagnoza()
                    {
                        SifraDijagnoze = reader.GetInt32(5),
                        NazivDijagnoze = reader.GetString(6),
                    }
                };

                return sk;
            }
            return null;
        }
    }
}
