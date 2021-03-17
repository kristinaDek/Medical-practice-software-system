using Domen;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace BrokerBazePodataka
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

     

        public Broker()
        {
            connection = new SqlConnection("Data Source=DESKTOP-0JRABR9;Initial Catalog=bazaProjekat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public List<IOpstiDomenskiObjekat> VratiObjekteKriterijum(string kriterijum, IOpstiDomenskiObjekat objekat)
        {
            SqlCommand commmand = new SqlCommand("", connection, transaction);
            commmand.CommandText = $"select * from {objekat.Tabela} {objekat.Join} {kriterijum} order by {objekat.Sort}";
            SqlDataReader reader = commmand.ExecuteReader();
            List<IOpstiDomenskiObjekat> rez = objekat.VratiListujoin(reader);
            reader.Close();
            return rez;
        }

        public Boolean SacuvajObjekat(IOpstiDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {objekat.Tabela} values ({objekat.VrednostiZaInsert})";
           
            if (command.ExecuteNonQuery() == 0)
                return false;
            return true;
        }

        public int VratiNovId(IOpstiDomenskiObjekat objekat)
        {
            try
            {
                SqlCommand command = new SqlCommand("", connection, transaction);
                command.CommandText = $"SELECT MAX({objekat.VrednostiID}) FROM {objekat.Tabela}";
                object rez = command.ExecuteScalar();
                if (rez is DBNull)
                {
                    return 1;
                }
                int maxid = (int)rez;
                return maxid + 1;
            }
            catch (Exception e)
            {
                
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public void OtvoriKonekciju()
        {
            connection.Open();
        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }



        public List<IOpstiDomenskiObjekat> VratiSveObjekte(IOpstiDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select * from {objekat.Tabela} {objekat.Join} order by {objekat.Sort}";
            SqlDataReader reader = command.ExecuteReader();
            List<IOpstiDomenskiObjekat> rezultat = objekat.VratiListu(reader);
            reader.Close();
            return rezultat;
        }

        public bool ObrisiObjekat(IOpstiDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from {objekat.Tabela} " +
                    $"where {objekat.PretragaID}";

            if (command.ExecuteNonQuery() <= 0)
                return false;
            return true;
        }


        public bool IzmeniObjekat(IOpstiDomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {objekat.Tabela} set {objekat.VrednostiZaUpdate} {objekat.Where}";
            if (command.ExecuteNonQuery() > 0)
                return true;
            return false;
        }
        public IOpstiDomenskiObjekat VratiObjekat(IOpstiDomenskiObjekat objekat)
        {
            SqlCommand commmand = new SqlCommand("", connection, transaction);
            commmand.CommandText = $"select * from {objekat.Tabela} where {objekat.PretragaID}";
            SqlDataReader reader = commmand.ExecuteReader();
            IOpstiDomenskiObjekat rez = objekat.VratiObjekat(reader);
            reader.Close();
            return rez;
        }


    }
}
