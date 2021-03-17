using Domen;
using Kontroler;
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
    public partial class FrmPrijavaKorisnika : Form
    {
        public FrmPrijavaKorisnika()
        {
            InitializeComponent();
        }

        private void BtnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (Komunikacija.Instance.PoveziSe())
            {
                string korIme = txtKorisnickoIme.Text;
                string pass = txtPassword.Text;
                Korisnik k = Komunikacija.Instance.Prijava(korIme, pass);
                if (k != null)
                {
                    MyMessageBox.Instance.Show($"Uspešno ste se prijavili na sistem.");
                    Sesija.Instance.Korisnik = k;
                    FrmGlavna forma = new FrmGlavna();
                    forma.ShowDialog();
                }
                else
                {
                    MyMessageBox.Instance.Show("Neuspešno prijavljivanje na sistem.");
                }
            }
            else
            {
                MyMessageBox.Instance.Show("Nije moguce povezati se sa serverom!");
            }
        }

        private void FrmPrijavaKorisnika_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
        }
    }
}
