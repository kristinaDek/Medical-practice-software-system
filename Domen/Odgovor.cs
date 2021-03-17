using System;
using System.Collections.Generic;
using System.Text;

namespace Domen
{
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; }
        public string Poruka { get; set; }
        public object Objekat { get; set; }
    }

    public enum Signal
    {
        Ok,
        Error
    }
}
