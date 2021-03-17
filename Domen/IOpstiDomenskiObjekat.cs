using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Domen
{
    public interface IOpstiDomenskiObjekat
    {
        string Tabela { get; }
        string VrednostiZaInsert { get; }
        string VrednostiID { get; }
        string PretragaID { get; }
        string Sort { get; }
        string Join { get; }
        string Where { get; }
        string VrednostiZaUpdate { get; }

        List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader reader);
        List<IOpstiDomenskiObjekat> VratiListujoin(SqlDataReader reader);
        IOpstiDomenskiObjekat VratiObjekat(SqlDataReader reader);
    }
}
