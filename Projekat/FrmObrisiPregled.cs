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
    public partial class FrmObrisiPregled : Form
    {
        Karton karton;
        BindingList<Pregled> listaPregleda = new BindingList<Pregled>();
        public FrmObrisiPregled(Karton karton)
        {
            this.karton = karton;
            InitializeComponent();
        }


        private void FrmObrisiPregled_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            Osvezi();                    
        }

        private void BtnObisi_Click(object sender, EventArgs e)
        {
            Pregled p = dgvPregl.CurrentRow.DataBoundItem as Pregled;

            if (p.Karton == null)
            {
                MyMessageBox.Instance.Show("Odaberite ponovo karton.");
            }
            else
            {
                Pregled provera = Komunikacija.Instance.ObrisiPregled(p);
                if (provera != null)
                {
                    MyMessageBox.Instance.Show($"Sistem je obrisao pregled\n za pacijenta {provera.Karton.ImeIPrezime}");
                    listaPregleda.Remove(p);
                    Osvezi();
                }
                else
                {
                    MyMessageBox.Instance.Show($"Sistem nije bio u mogucnosti\n da obrise pregled pacijenta {p.Karton.ImeIPrezime}");
                    return;
                }
            }
        }

        public void Osvezi()
        {
            if (listaPregleda != null)
                listaPregleda.Clear();
            listaPregleda = new BindingList<Pregled>((List<Pregled>)Komunikacija.Instance.vratiSvePregledeZaKarton(karton)); ;
            dgvPregl.DataSource = listaPregleda;
            dgvPregl.Refresh();

        }
    }
}
