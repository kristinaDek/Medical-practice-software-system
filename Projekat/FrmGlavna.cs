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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void BtnUnosKartona_Click(object sender, EventArgs e)
        {
            FrmUnosKartona unos = new FrmUnosKartona();
            unos.ShowDialog();
        }

        private void BtnPretragaKartona_Click(object sender, EventArgs e)
        {
            FrmPretragaKartona pretraga = new FrmPretragaKartona();
            pretraga.ShowDialog();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            lbltekst.Text = "Ulogovani: " + Sesija.Instance.Korisnik.ToString();
        }

        private void BtnBrisanjeKartona_Click(object sender, EventArgs e)
        {
            FrmObrisiKarton obrisi = new FrmObrisiKarton();
            obrisi.ShowDialog();
        }

        private void BtnUnosPregleda_Click(object sender, EventArgs e)
        {
            FrmPretragaUnos pretragaUnos = new FrmPretragaUnos();
            pretragaUnos.ShowDialog();
        }

        private void BrnPretragaPregleda_Click(object sender, EventArgs e)
        {
            FrmPretragaPregleda pretraga = new FrmPretragaPregleda();
            pretraga.ShowDialog();

        }

        private void BtnBrisanjePregleda_Click(object sender, EventArgs e)
        {
            FrmPretragaKartona pret = new FrmPretragaKartona();
            pret.ShowDialog();

        }
    }
}
