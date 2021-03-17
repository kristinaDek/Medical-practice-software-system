using BrokerBazePodataka;
using Domen;
using System;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        protected Broker broker = new Broker();

        public void IzvrsiSO(IOpstiDomenskiObjekat objekat)
        {
            try
            {
                broker.OtvoriKonekciju();
                broker.PokreniTransakciju();
                Validacija(objekat);
                IzvrsiKonkretnuOperaciju(objekat);
                broker.Commit();
            }
            catch
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.ZatvoriKonekciju();
            }
        }

        protected abstract void Validacija(IOpstiDomenskiObjekat objekat);

        protected abstract void IzvrsiKonkretnuOperaciju(IOpstiDomenskiObjekat objekat);
    }
}
