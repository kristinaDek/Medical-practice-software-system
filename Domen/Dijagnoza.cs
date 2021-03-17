using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Dijagnoza:IOpstiDomenskiObjekat
    {
        private int sifraDijagnoze;
        private String nazivDijagnoze;

        public Dijagnoza(int sifraDijagnoze)
        {
            this.SifraDijagnoze = sifraDijagnoze;
        }

        public Dijagnoza()
        {
            
        }

        public int SifraDijagnoze { get => sifraDijagnoze; set => sifraDijagnoze = value; }
        public string NazivDijagnoze { get => nazivDijagnoze; set => nazivDijagnoze = value; }
        [Browsable(false)]
        public string Tabela => "Dijagnoza";
        [Browsable(false)]
        public string VrednostiZaInsert => $"{SifraDijagnoze}, {NazivDijagnoze}";
        [Browsable(false)]
        public string VrednostiID => "SifraDijagnoze";
        [Browsable(false)]
        public string PretragaID => $"SifraDijagnoze = {SifraDijagnoze}";
        [Browsable(false)]
        public string Join => "";

        [Browsable(false)]
        public string Sort => "NazivDijagnoze";
        [Browsable(false)]
        public string Where => $"";
        [Browsable(false)]
        public string VrednostiZaUpdate => "";

        public override string ToString()
        {
            return sifraDijagnoze + " - "+nazivDijagnoze;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {                
                Dijagnoza dk = new Dijagnoza()
                {
                    SifraDijagnoze = reader.GetInt32(0),
                    NazivDijagnoze = reader.GetString(1),
                };
              
                lista.Add(dk);                
            }
            return lista;
        }

        public List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader)
        {
            List<IOpstiDomenskiObjekat> lista = new List<IOpstiDomenskiObjekat>();
            while (reader.Read())
            {
                Dijagnoza dk = new Dijagnoza()
                {
                    SifraDijagnoze = reader.GetInt32(0),
                    NazivDijagnoze = reader.GetString(1),
                };

                lista.Add(dk);
            }
            return lista;
        }

        public IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader)
        {
            
            if (reader.Read())
            {
                Dijagnoza dk = new Dijagnoza()
                {
                    SifraDijagnoze = reader.GetInt32(0),
                    NazivDijagnoze = reader.GetString(1),
                };

                return dk;
            }
            return null;
        }
    }
}
