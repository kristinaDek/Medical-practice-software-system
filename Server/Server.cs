using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;
using Domen;

namespace Server
{
    public class Server
    {
        private Socket osluskujuciSocket;
        //public List<Socket> klijenti = new List<Socket>();
        public List<Socket> Klijenti { get; internal set; } = new List<Socket>();
        public List<Korisnik> Zaposleni { get; internal set; } = new List<Korisnik>();

        public bool PokreniServer()
        {
            try
            {
                osluskujuciSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["host"]),int.Parse(ConfigurationManager.AppSettings["port"]));
                osluskujuciSocket.Bind(endpoint);
                osluskujuciSocket.Listen(5);

                return true;
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>>>>>>" + se.Message);
                
                return false;
            }
        }
        
        public void Osluskuj()
        {
            try
            {
                bool kraj = false;
                while (!kraj)
                {
                    try
                    {
                        Socket klijentskiSocket = osluskujuciSocket.Accept();
                        Klijenti.Add(klijentskiSocket);
                        Obrada obrada = new Obrada(klijentskiSocket, this);
                        Thread nitKlijenta = new Thread(obrada.ObradaZahteva);
                        nitKlijenta.Start();
                    }
                    catch (Exception)
                    {
                        kraj = true;
                    }
                }
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>"+se.Message);
            }
        }

        public bool Zaustavi()
        {
            try
            {
                foreach (var o in Klijenti)
                {
                    o.Close();
                }
                osluskujuciSocket.Close();
                Klijenti.Clear();
                return true;
            }
            catch (SocketException se)
            {
                Debug.WriteLine(">>>" + se.Message);
                return false;
            }
        }
    }
}
