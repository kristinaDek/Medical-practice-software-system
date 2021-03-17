using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmObrisiKarton : Form
    {
        BindingList<Karton> listaKartona = new BindingList<Karton>();
        BindingList<String> lista = new BindingList<string>();
        public FrmObrisiKarton()
        {
            InitializeComponent();
        }

        private void FrmObrisiKarton_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            Osvezi();
        }

       

        private void BtnObrisiKarton_Click(object sender, EventArgs e)
        {
            Karton k = new Karton();
            k = lbKartoni.SelectedItem as Karton;
            
            if (k == null)
            {
                MyMessageBox.Instance.Show("Odaberite ponovo karton.");
            }
            else
            {
                Karton provera = Komunikacija.Instance.ObrisiKarton(k);
                if (provera != null)
                {

                    MyMessageBox.Instance.Show($"Sistem je obrisao karton\n pacijenta {provera.ImeIPrezime}");

                    Osvezi();

                }
                else
                {
                    MyMessageBox.Instance.Show($"Sistem nije bio u mogucnosti\n da obrise karton pacijenta {k.ImeIPrezime}");
                    return;
                }
               
            }
        }

        public void Osvezi()
        {
            if(listaKartona != null)
                listaKartona.Clear();
            listaKartona = new BindingList<Karton>(Komunikacija.Instance.VratiSveKartone());
            if (listaKartona.Count == 0)
            {                
                lbKartoni.DataSource = listaKartona;
                MyMessageBox.Instance.Show("Baza kartona je prazna.");
                return;
            }
                      
            lbKartoni.DataSource = listaKartona;
        }

     
    }
}
