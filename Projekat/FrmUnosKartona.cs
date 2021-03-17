using Domen;
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

namespace Projekat
{
    public partial class FrmUnosKartona : Form
    {
        private List<Karton> lista = Komunikacija.Instance.VratiSveKartone();
        public FrmUnosKartona()
        {
            InitializeComponent();
        }

        private Karton VratiKarton()
        {
            bool validacija = true;
            Karton karton = new Karton();

            if (string.IsNullOrEmpty(txtJMBG.Text) || txtJMBG.Text.Length != 13)
            {
                txtJMBG.BackColor = Color.LightCoral;
                
                validacija = false;
                
            }
            else
            {
                karton.Jmbg = txtJMBG.Text;
            }
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                txtIme.BackColor = Color.LightCoral;
                
                validacija = false;
            }
            else
            {
                karton.ImeIPrezime = txtIme.Text;
            }
            
            if (string.IsNullOrEmpty(txtDatumRodjenja.Text) || !DateTime.TryParseExact(txtDatumRodjenja.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
            {
                txtDatumRodjenja.BackColor = Color.LightCoral;
                
                validacija = false;
            }
            else
            {
                karton.DatumRodjenja = datum;
            }


            if (validacija)
            {
                return karton;
            }
            else
            {
                return null;
            }
        }

        private void BtnUnesiKarton_Click(object sender, EventArgs e)
        {
            try
            {
                if (VratiKarton() != null)
                {
                    Karton karton = VratiKarton();
                    foreach (Karton ka in lista)
                    {
                        if (ka.Equals(karton))
                        {

                            MyMessageBox.Instance.Show($"Greska!\n Nije moguce sacuvati karton\n {karton.ToString()}");
                            OcistiFormu();
                            return;
                        }                        
                    }
                    Karton sacuvan = Komunikacija.Instance.SacuvajKarton(karton);
                    if (sacuvan.Proveri(karton))
                    {
                        MyMessageBox.Instance.Show($"Uspesno sacuvan karton\n {karton.ToString()}");
                        OcistiFormu();
                    }
                    else
                    {
                        MyMessageBox.Instance.Show($"Greska!\n Nije moguce sacuvati karton\n {karton.ToString()}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void OcistiFormu()
        {
            txtJMBG.Clear();
            txtIme.Text = String.Empty;
            
            txtDatumRodjenja.Clear();
        }

        private void FrmUnosKartona_Load(object sender, EventArgs e)
        {
            lbltekst.Visible = true;
            this.Text = "[Oftal k2] Klijentski program";
        }

        private void TxtDatumRodjenja_TextChanged(object sender, EventArgs e)
        {
            txtDatumRodjenja.BackColor = Color.LightGray;
        }

        private void TxtIme_TextChanged(object sender, EventArgs e)
        {
            txtIme.BackColor = Color.LightGray;
        }

        private void TxtJMBG_TextChanged(object sender, EventArgs e)
        {
            txtJMBG.BackColor = Color.LightGray;
        }

       
    }
}
