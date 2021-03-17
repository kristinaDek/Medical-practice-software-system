using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Projekat
{
    public partial class FrmIzmeniKarton : Form
    {
        Karton karton;
        public FrmIzmeniKarton()
        {
            InitializeComponent();
        }
        public FrmIzmeniKarton(Karton karton)
        {            
            InitializeComponent();
            this.karton = karton;
            //this.k = k;
        }

        private void FrmIzmeniKarton_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            txtSifraKartona.Text = karton.SifraKartona.ToString();
            txtjmbg.Text = karton.Jmbg;
            txtiip.Text = karton.ImeIPrezime;
            txtdatum.Text = karton.DatumRodjenja.ToString("dd/MM/yyyy");   //.Substring(0, karton.DatumRodjenja.ToString().IndexOf(" "));
        }

        private void BtnZapamtiIzmene_Click(object sender, EventArgs e)
        {

            Karton k = VratiKarton();

            if (!karton.proveriIsto(k))
            {
                karton = k;
                //bool izmena = false;
                Karton k1 = Komunikacija.Instance.IzmeniKarton(karton);

                if (k1.proveriIsto(karton))
                {
                    karton = k1;
                    MyMessageBox.Instance.Show($"Izabrani karton pacijenta\n {karton.ImeIPrezime} je izmenjen");
                    FrmPrikaziKarton prikazi = new FrmPrikaziKarton(karton);
                    prikazi.ShowDialog();
                    return;
                }
                else
                {
                    MyMessageBox.Instance.Show($"Greska! \nIzabrani karton pacijenta {karton.ImeIPrezime}\n nije mogao biti izmenjen");
                    return;
                }
            }
            else
            {

                MyMessageBox.Instance.Show($"Morate izmeniti vrednosti za izabrani karton\n pacijenta {karton.ImeIPrezime} kako bi bio izmenjen.");
                return;
            }
        }

        private Karton VratiKarton()
        {
            Karton k = new Karton();
            k.SifraKartona = karton.SifraKartona;
            //k.SifraKartona = karton.SifraKartona;
           
            bool provera = true;

            if (string.IsNullOrEmpty(txtjmbg.Text) || txtjmbg.Text.Length != 13)
            {
                MyMessageBox.Instance.Show("Ponovo unesite\n vrednost jmbg!");
                txtjmbg.Focus();
                provera = false;

            }
            else k.Jmbg = txtjmbg.Text;

            if (string.IsNullOrEmpty(txtiip.Text) || !txtiip.Text.Contains(" "))
            {
                MyMessageBox.Instance.Show("Ponovo unesite\n ime i prezime!");
                txtiip.Focus();
                provera = false;

            }
            else k.ImeIPrezime = txtiip.Text;


            if (string.IsNullOrEmpty(txtdatum.Text) || !DateTime.TryParseExact(txtdatum.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
            {
                MyMessageBox.Instance.Show("Morate uneti datum\n u formatu: dd/MM/yyyy.");
                lbltekst.Visible = true;
                this.Refresh();
                txtdatum.Focus();
                provera = false;
            }
            else k.DatumRodjenja = datum;

            if (provera && !k.proveriIsto(karton))
                return k;
            else
                return karton;
        }

        
    }
}
